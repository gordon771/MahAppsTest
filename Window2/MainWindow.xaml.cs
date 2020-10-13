using GUILib;
using System.Windows;
using System.Windows.Controls;

namespace MahAppsTest.Window2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : WindowBase
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = (ContextMenu)FindResource("contextMenu");
            cm.PlacementTarget = (Button)sender;
            cm.IsOpen = true;
        }
    }
}
