using MahApps.Metro.Controls;
using System;
using System.Windows;

namespace GUILib
{
	public class WindowBase : MetroWindow
	{
		public WindowBase()
		{
            ResourceDictionary dictResMain = new ResourceDictionary();
            ResourceDictionary dictRes = new ResourceDictionary();

            // Define Metro style
            dictRes.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml");
            dictResMain.MergedDictionaries.Add(dictRes);
            dictRes = new ResourceDictionary();
            dictRes.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml");
            dictResMain.MergedDictionaries.Add(dictRes);
            dictRes = new ResourceDictionary();
            dictRes.Source = new Uri("pack://application:,,,/MahApps.Metro;component/Styles/Themes/Light.Blue.xaml");
            dictResMain.MergedDictionaries.Add(dictRes);            

            this.Resources = dictResMain;
        }
	}
}
