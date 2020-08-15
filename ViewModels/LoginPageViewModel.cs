using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Input;
using WiFiStateMonitor.Annotations;
using WiFiStateMonitor.Commands;
using WiFiStateMonitor.Services;
using WiFiStateMonitor.Services.Enums;

namespace WiFiStateMonitor.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        private readonly IConnectionHandler _connectionHandler;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler LoginSuccessful;
        public event EventHandler ExitEvent;

        public string LoginResponseText { get; set; } = string.Empty;

        public string Username { get; set; }
        public SecureString Password { get; set; }

        public ICommand LoginCommand { get; set; }
        public ICommand ExitCommand { get; set; }

        public LoginPageViewModel(IConnectionHandler connectionHandler)
        {
            _connectionHandler = connectionHandler;
            LoginCommand = new RelayCommand(Login);
            ExitCommand = new EventRelayCommand(OnExitClicked);
        }

        public void Login()
        {
            var result = _connectionHandler.Connect(Username, Password);

            result.ContinueWith(task =>
            {
                switch (task.Result)
                {
                    case LoginResult.Successful:
                        OnLoginSuccessful();
                        return;
                }

                LoginResponseText = "Login failed";
                OnPropertyChanged(nameof(LoginResponseText));
            });
        }

        private void OnLoginSuccessful()
        {
            LoginSuccessful?.Invoke(this, EventArgs.Empty);
        }
        private void OnExitClicked(object sender, EventArgs arguments)
        {
            ExitEvent?.Invoke(sender, arguments);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}