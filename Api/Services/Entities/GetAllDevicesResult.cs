using System.Collections.Generic;
using WiFiStateMonitor.Api.Rest.Enums;

namespace WiFiStateMonitor.Api.Services.Entities
{
    public class GetAllDevicesResult
    {
        public RestResponseStatus ResponseStatus { get; set; }

        public IEnumerable<DeviceRecord> Devices { get; set; }
    }
}