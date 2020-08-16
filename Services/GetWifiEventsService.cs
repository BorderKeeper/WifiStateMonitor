using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Api.Services.Enums;
using WiFiStateMonitor.Api.Wifi.Enums;
using WiFiStateMonitor.Common.Extensions;
using WiFiStateMonitor.Rest;

namespace WiFiStateMonitor.Services
{
    public class GetWifiEventsService : BaseService, IGetWifiEventsService
    {
        private const string GetWifiEventsLink = "https://parse-wandera.herokuapp.com/parse/classes/WiFiEvent";

        private readonly IRestService _restService;

        public GetWifiEventsService()
        {
            _restService = new RestService();
        }

        public async Task<GetWifiEventsResult> GetEvents(RestSession session, string objectId)
        {
            var headers = SessionToHeaders(session);

            var parameters = new Dictionary<string, string>
            {
                { "where", $"{{\"device\":{{\"__type\":\"Pointer\",\"className\":\"Device\",\"objectId\":\"{objectId}\"}}}}" }
            };

            var result = await _restService.SendRestGetRequest(GetWifiEventsLink, headers, parameters);

            if (result.Status == RestResponseStatus.Ok)
            {
                var message = JsonSerializer.Deserialize<WifiEventMessage>(result.Data);
                var wifiEvents = message.WifiEvents.Select(row => new WifiEvent(EnumerationExtensions.GetEnumValueFromDescription<WifiEventType>(row.EventType), row.CreatedAt));

                return new GetWifiEventsResult { ResponseStatus = RestResponseStatus.Ok, WifiEvents = wifiEvents };
            }

            return new GetWifiEventsResult { ResponseStatus = RestResponseStatus.Error };
        }

        private class WifiEventMessage
        {
            [JsonPropertyName("results")]
            public IEnumerable<WifiEventRow> WifiEvents { get; set; }
        }

        private class WifiEventRow
        {
            [JsonPropertyName("objectId")]
            public string ObjectId { get; set; }

            [JsonPropertyName("device")]
            public Device Device { get; set; }

            [JsonPropertyName("eventType")]
            public string EventType { get; set; }

            [JsonPropertyName("createdAt")]
            public DateTime CreatedAt { get; set; }

            [JsonPropertyName("updatedAt")]
            public DateTime UpdatedAt { get; set; }
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