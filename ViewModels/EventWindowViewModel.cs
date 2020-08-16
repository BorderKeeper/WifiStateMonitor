using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using WiFiStateMonitor.Annotations;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Enums;
using WiFiStateMonitor.Commands;
using WiFiStateMonitor.Services;
using WiFiStateMonitor.ViewModels.Entities;

namespace WiFiStateMonitor.ViewModels
{
    public class EventWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<WifiEventRow> EventList { get; set; }

        public ICommand CloseWindowCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler ExitButtonClicked;

        private readonly IGetWifiEventsService _getWifiEventsService;
        private readonly IConnectionHandler _connectionHandler;

        public EventWindowViewModel(IConnectionHandler connectionHandler)
        {
            _getWifiEventsService = new GetWifiEventsService();
            _connectionHandler = connectionHandler;

            EventList = new ObservableCollection<WifiEventRow>();
            CloseWindowCommand = new EventRelayCommand(OnExitButtonClicked);

            LoadEvents();
        }

        private void LoadEvents()
        {
            EventList.Clear();
            EventList.Add(new WifiEventRow("Loading Events..."));

            _ = GetEventsAsync();
        }

        private async Task GetEventsAsync()
        {
            EventList.Clear();

            if (!_connectionHandler.IsConnected())
            {
                EventList.Add(new WifiEventRow("You are not logged in!"));
                return;
            }

            var session = _connectionHandler.GetSession();
            var events = await _getWifiEventsService.GetEvents(session, session.ObjectId);

            if (events.ResponseStatus != RestResponseStatus.Ok)
            {
                EventList.Add(new WifiEventRow("Error connecting to the backend services!"));
                return;
            }

            foreach (WifiEvent wifiEvent in events.WifiEvents)
            {
                EventList.Add(new WifiEventRow(wifiEvent.ToString()));
            }
        }

        private void OnExitButtonClicked(object sender, EventArgs arguments)
        {
            ExitButtonClicked?.Invoke(sender, arguments);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}