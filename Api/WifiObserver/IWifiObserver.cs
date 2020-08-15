using System;
using WiFiStateMonitor.Api.WifiObserver.Entities;

namespace WiFiStateMonitor.Api.WifiObserver
{
    public interface IWifiObserver : IDisposable
    {
        event EventHandler<WifiStateChangedArguments> WifiStateChanged;

        void StartListening();

        void StopListening();
    }
}