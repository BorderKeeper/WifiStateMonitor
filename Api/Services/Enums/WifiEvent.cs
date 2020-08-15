﻿using System;

namespace WiFiStateMonitor.Api.Services.Enums
{
    public class WifiEvent
    {
        public string Info { get; set; }

        public DateTime TimeStamp { get; set; }

        public WifiEvent(string info)
        {
            Info = info;
            TimeStamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Info} | {TimeStamp.ToShortTimeString()}";
        }
    }
}