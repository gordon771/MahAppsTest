using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;

namespace MahAppsTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ((App)Application.Current).GUIManager.CreateWindow("Window1.dll", "Window1", "My Window 1");
        }

        private void MenuItem2_Click(object sender, RoutedEventArgs e)
        {
            ((App)Application.Current).GUIManager.CreateWindow("Window2.dll", "Window2", "My Window 2");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = (ContextMenu)FindResource("cmUserLevel");
            cm.PlacementTarget = (Button)sender;
            cm.IsOpen = true;
        }
    }
}
