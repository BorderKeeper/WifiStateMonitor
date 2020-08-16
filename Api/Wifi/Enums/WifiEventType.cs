using System.ComponentModel;

namespace WiFiStateMonitor.Api.Wifi.Enums
{
    public enum WifiEventType
    {
        [Description("disconnect")]
        Disconnected,
        [Description("connect")]
        Connected
    }
}