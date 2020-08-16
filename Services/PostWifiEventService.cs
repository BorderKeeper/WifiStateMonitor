using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Api.Services.Enums;
using WiFiStateMonitor.Common.Extensions;
using WiFiStateMonitor.Rest;

namespace WiFiStateMonitor.Services
{
    public class PostWifiEventService : BaseService, IPostWifiEventService
    {
        private const string PostWifiEventLink = "https://parse-wandera.herokuapp.com/parse/classes/WiFiEvent/";

        private readonly IRestService _restService;

        public PostWifiEventService()
        {
            _restService = new RestService();
        }

        public async Task<RestResponseStatus> PostWifiEvent(RestSession session, WifiEvent wifiEvent)
        {
            var headers = SessionToHeaders(session);

            var message = new WifiEventMessage
            {
                EventType = wifiEvent.EventType.ToDescription(),
                Device = new Device
                {
                    ClassName = "Device",
                    Type = "Pointer",
                    ObjectId = session.ObjectId
                }
            };

            var content = JsonSerializer.Serialize(message);

            var result = await _restService.SendRestPostRequest(PostWifiEventLink, headers, content);

            return result.Status;
        }

        private class WifiEventMessage
        {
            [JsonPropertyName("device")]
            public Device Device { get; set; }

            [JsonPropertyName("eventType")]
            public string EventType { get; set; }
        }

        private class Device
        {
            [JsonPropertyName("__type")]
            public string Type { get; set; }

            [JsonPropertyName("className")]
            public string ClassName { get; set; }

            [JsonPropertyName("objectId")]
            public string ObjectId { get; set; }
        }
    }
}