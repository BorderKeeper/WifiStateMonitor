using System.Text.Json.Serialization;
using WiFiStateMonitor.Api.Services.Enums;

namespace WiFiStateMonitor.Api.Services.Entities
{
    public class Device
    {
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }

        [JsonPropertyName("osType")]
        public OsType OsType { get; set; }

        [JsonPropertyName("countryIsoCode")]
        public CountryIsoCode Country { get; set; }

        [JsonPropertyName("otherDomesticCountryIsoCode")]
        public CountryIsoCode OtherDomesticCountry { get; set; }
    }
}