using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using WiFiStateMonitor.Annotations;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Enums;
using WiFiStateMonitor.Commands;
using WiFiStateMonitor.Services;

namespace WiFiStateMonitor.ViewModels
{
    public class EventWindowViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<WifiEvent> EventList { get; set; }

        public ICommand CloseWindowCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler ExitButtonClicked;

        private readonly IGetWifiEventsService _getWifiEventsService;

        public EventWindowViewModel()
        {
            CloseWindowCommand = new EventRelayCommand(OnExitButtonClicked);
        }

        public void LoadEvents()
        {
            EventList.Clear();
            EventList.Add(new WifiEvent("Loading Events..."));

            _ = GetEventsAsync();
        }

        private async Task GetEventsAsync()
        {
            var events = await _getWifiEventsService.GetEvents();

            EventList.Clear();

            foreach (WifiEvent wifiEvent in events)
            {
                EventList.Add(wifiEvent);
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