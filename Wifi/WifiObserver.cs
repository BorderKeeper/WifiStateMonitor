using System;
using System.Net.NetworkInformation;
using WiFiStateMonitor.Api.Wifi;
using WiFiStateMonitor.Api.Wifi.Entities;
using WiFiStateMonitor.Api.Wifi.Enums;

namespace WiFiStateMonitor.Wifi
{
    public class WifiObserver : IWifiObserver
    {
        public event EventHandler<WifiStateChangedArguments> WifiStateChanged;

        public void StartListening()
        {
            NetworkChange.NetworkAvailabilityChanged += NetworkAvailabilityChanged;
        }

        public void StopListening()
        {
            NetworkChange.NetworkAvailabilityChanged -= NetworkAvailabilityChanged;
        }

        private void NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            WifiStateChanged?.Invoke(this, new WifiStateChangedArguments { EventType = e.IsAvailable ? WifiEventType.Connected : WifiEventType.Disconnected });
        }
    }
}