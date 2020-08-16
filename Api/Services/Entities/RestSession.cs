using System;
using System.Text.Json.Serialization;
using WiFiStateMonitor.Api.Configuration.Entities;

namespace WiFiStateMonitor.Api.Services.Entities
{
    public class RestSession
    {
        [JsonIgnore]
        public RestConfiguration Configuration { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("objectId")]
        public string ObjectId { get; set; }

        [JsonPropertyName("sessionToken")]
        public string SessionToken { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}