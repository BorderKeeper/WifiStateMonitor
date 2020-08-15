using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WiFiStateMonitor.Annotations;
using WiFiStateMonitor.Commands;
using WiFiStateMonitor.Views;

namespace WiFiStateMonitor.ViewModels
{
    public class StatusPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler LogoutEvent;
        public event EventHandler ExitEvent;

        public string InfoBarText { get; set; } = "Logged in as: ledr.jan@gmail.com";

        public ICommand ViewEventsCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand ExitCommand { get; set; }

        private bool _eventWindowOpened = false;

        public StatusPageViewModel()
        {
            ViewEventsCommand = new RelayCommand(OpenEventWindow);
            LogoutCommand = new EventRelayCommand(OnLogoutClicked);
            ExitCommand = new EventRelayCommand(OnExitClicked);
        }

        private void OpenEventWindow()
        {
            if (!_eventWindowOpened)
            {
                _eventWindowOpened = true;

                var eventWindow = new EventWindow();
                var eventWindowViewModel = new EventWindowViewModel();

                eventWindowViewModel.ExitButtonClicked += (sender, args) =>
                {
                    eventWindow.Close();
                    _eventWindowOpened = false;
                };

                eventWindow.DataContext = eventWindowViewModel;
                eventWindow.Show();
            }
        }

        private void OnLogoutClicked(object sender, EventArgs arguments)
        {
            LogoutEvent?.Invoke(sender, arguments);
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