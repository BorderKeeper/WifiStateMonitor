using System;

namespace WiFiStateMonitor.WifiObserver
{
    public interface IWifiObserver : IDisposable
    {
        event EventHandler<WifiStateChangedArguments> WifiStateChanged;

        void StartListening();

        void StopListening();
    }
}