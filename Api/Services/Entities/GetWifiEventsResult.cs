using System.Collections.Generic;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services.Enums;

namespace WiFiStateMonitor.Api.Services.Entities
{
    public class GetWifiEventsResult
    {
        public RestResponseStatus ResponseStatus { get; set; }

        public IEnumerable<WifiEvent> WifiEvents { get; set; }
    }
}