using System;
using System.Text.Json.Serialization;

namespace WiFiStateMonitor.Api.Services.Entities
{
    public class DeviceRecord : Device
    {
        [JsonPropertyName("objectId")]
        public string ObjectId { get; set; }

        [JsonPropertyName("trafficCounter")]
        public int TrafficCounter { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("roaming")]
        public bool Roaming { get; set; }
    }
}