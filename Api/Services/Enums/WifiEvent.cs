using System;
using WiFiStateMonitor.Api.Wifi.Enums;

namespace WiFiStateMonitor.Api.Services.Enums
{
    public class WifiEvent
    {
        public WifiEventType EventType { get; set; }

        public DateTime TimeStamp { get; set; }

        public WifiEvent(WifiEventType eventType)
        {
            EventType = eventType;
            TimeStamp = DateTime.Now;
        }

        public WifiEvent(WifiEventType eventType, DateTime timeStamp)
        {
            EventType = eventType;
            TimeStamp = timeStamp;
        }

        public override string ToString()
        {
            return $"{EventType} | {TimeStamp.ToShortTimeString()}";
        }
    }
}