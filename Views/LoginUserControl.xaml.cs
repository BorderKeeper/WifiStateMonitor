using System.Windows;
using System.Windows.Controls;
using WiFiStateMonitor.ViewModels;

namespace WiFiStateMonitor.Views
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext != null)
            {
                (DataContext as LoginPageViewModel).Password = (sender as PasswordBox).SecurePassword;
            }
        }
    }
}
