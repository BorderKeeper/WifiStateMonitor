using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WiFiStateMonitor.Annotations;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Enums;
using WiFiStateMonitor.Api.Wifi;
using WiFiStateMonitor.Api.Wifi.Entities;
using WiFiStateMonitor.Commands;
using WiFiStateMonitor.Services;
using WiFiStateMonitor.Views;
using WiFiStateMonitor.Wifi;

namespace WiFiStateMonitor.ViewModels
{
    public class StatusPageViewModel : INotifyPropertyChanged
    {
        private readonly IConnectionHandler _connectionHandler;
        private readonly IPostWifiEventService _postWifiEventService;
        private readonly IWifiObserver _wifiObserver;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler LogoutEvent;
        public event EventHandler ExitEvent;

        public string InfoBarText { get; set; } = "Logged in as: ledr.jan@gmail.com";

        public ICommand ViewEventsCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand ExitCommand { get; set; }

        private bool _eventWindowOpened = false;

        public StatusPageViewModel(IConnectionHandler connectionHandler)
        {
            _connectionHandler = connectionHandler;
            _wifiObserver = new WifiObserver();
            _postWifiEventService = new PostWifiEventService();

            ViewEventsCommand = new RelayCommand(OpenEventWindow);
            LogoutCommand = new EventRelayCommand(OnLogoutClicked);
            ExitCommand = new EventRelayCommand(OnExitClicked);

            if (_connectionHandler.IsConnected())
            {
                _wifiObserver.WifiStateChanged += WifiStateChanged;
                _wifiObserver.StartListening();
            }
        }

        private void WifiStateChanged(object? sender, WifiStateChangedArguments e)
        {
            _ = _postWifiEventService.PostWifiEvent(_connectionHandler.GetSession(), new WifiEvent(e.EventType));
        }

        private void OpenEventWindow()
        {
            if (!_eventWindowOpened)
            {
                _eventWindowOpened = true;

                var eventWindow = new EventWindow();
                var eventWindowViewModel = new EventWindowViewModel(_connectionHandler);

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
            _wifiObserver.StopListening();
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