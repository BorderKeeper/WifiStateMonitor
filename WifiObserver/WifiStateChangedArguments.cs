using WiFiStateMonitor.WifiObserver.Enums;

namespace WiFiStateMonitor.WifiObserver
{
    public class WifiStateChangedArguments
    {
        public WifiEventType EventType { get; set; }

        public string Details { get; set; }
    }
}