using WiFiStateMonitor.Api.Rest.Enums;

namespace WiFiStateMonitor.Api.Services.Entities
{
    public class GetDeviceRecordResult
    {
        public RestResponseStatus ResponseStatus { get; set; }

        public DeviceRecord Record { get; set; }
    }
}