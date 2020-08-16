using System;
using WiFiStateMonitor.Api.Wifi.Entities;

namespace WiFiStateMonitor.Api.Wifi
{
    public interface IWifiObserver
    {
        event EventHandler<WifiStateChangedArguments> WifiStateChanged;

        void StartListening();

        void StopListening();
    }
}