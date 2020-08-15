using System.Windows;
using WiFiStateMonitor.ViewModels;

namespace WiFiStateMonitor.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
