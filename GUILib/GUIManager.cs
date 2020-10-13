using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Threading;

namespace GUILib
{
	public class GUIManager
	{
		public List<WindowBase> mOpenWindows = new List<WindowBase>();

		public GUIManager()
		{
		}

        private static object lockObject = new object();
        public void CreateWindow(string assembly, string className, string title)
		{
            string assemblyFullName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), assembly);

            if (!File.Exists(assemblyFullName))
                return;

            Assembly dllAssembly = Assembly.LoadFile(assemblyFullName);
            String dialogClass = "MahAppsTest." + className + ".MainWindow";

            // create window in own thread
            Thread thread = new Thread(() =>
            {
                lock (lockObject)
                {
                    SynchronizationContext.SetSynchronizationContext(new DispatcherSynchronizationContext(Dispatcher.CurrentDispatcher));  // create and install a context

                    WindowBase wnd = (WindowBase)dllAssembly.CreateInstance(dialogClass);                  
                    wnd.Closed += (s, e) => Dispatcher.CurrentDispatcher?.BeginInvokeShutdown(DispatcherPriority.Background);

                    wnd.Title = title;

                    wnd.Show();

                    //mOpenWindows.Add(wnd);
                }

                Dispatcher.Run();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = false;            

            thread.Start();
        }
	}
}
