using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using WiFiStateMonitor.Annotations;
using WiFiStateMonitor.Services;
using WiFiStateMonitor.Views;

namespace WiFiStateMonitor.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly IConnectionHandler _connectionHandler;

        public UserControl CurrentPage { get; set; }

        public MainWindowViewModel()
        {
            _connectionHandler = new ConnectionHandler();

            DisplayLoginPage();
            OnPropertyChanged(nameof(CurrentPage));
        }

        private void LoginSuccessful(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                DisplayStatusPage();
                OnPropertyChanged(nameof(CurrentPage));
            });
        }

        private void Logout(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                DisplayLoginPage();
                OnPropertyChanged(nameof(CurrentPage));
            });
        }

        private void DisplayLoginPage()
        {
            var loginPageViewModel = new LoginPageViewModel(_connectionHandler);
            loginPageViewModel.LoginSuccessful += LoginSuccessful;
            loginPageViewModel.ExitEvent += ExitApplication;

            CurrentPage = new LoginUserControl();
            CurrentPage.DataContext = loginPageViewModel;
        }

        private void DisplayStatusPage()
        {
            var statusPageViewModel = new StatusPageViewModel();
            statusPageViewModel.LogoutEvent += Logout;
            statusPageViewModel.ExitEvent += ExitApplication;

            CurrentPage = new StatusUserControl();
            CurrentPage.DataContext = statusPageViewModel;
        }

        private void ExitApplication(object sender, EventArgs arguments)
        {
            Application.Current.Shutdown();
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}