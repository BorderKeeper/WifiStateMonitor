using WiFiStateMonitor.Api.Services.Enums;

namespace WiFiStateMonitor.Api.Services.Entities
{
    public class DeviceStatusUpdate
    {
        public CountryIsoCode Country { get; set; }

        public decimal Traffic { get; set; }
    }
}