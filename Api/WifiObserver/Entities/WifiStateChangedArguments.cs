using WiFiStateMonitor.Api.WifiObserver.Enums;

namespace WiFiStateMonitor.Api.WifiObserver.Entities
{
    public class WifiStateChangedArguments
    {
        public WifiEventType EventType { get; set; }

        public string Details { get; set; }
    }
}