using GUILib;
using System.Windows;

namespace MahAppsTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public GUIManager GUIManager { get; set; } = new GUIManager();

    }
}
