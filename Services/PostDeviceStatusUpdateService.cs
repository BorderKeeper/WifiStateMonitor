using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Api.Services.Enums;
using WiFiStateMonitor.Rest;

namespace WiFiStateMonitor.Services
{
    public class PostDeviceStatusUpdateService : BaseService, IPostDeviceStatusUpdateService
    {
        private const string PostDeviceStatusLink = "https://parse-wandera.herokuapp.com/parse/classes/StatusUpdate/";

        private readonly IRestService _restService;

        public PostDeviceStatusUpdateService()
        {
            _restService = new RestService();
        }

        public async Task<RestResponseStatus> PostDeviceStatusUpdate(RestSession session, DeviceStatusUpdate statusUpdate)
        {
            var headers = SessionToHeaders(session);
            var message = new StatusUpdateMessage
            {
                Country = statusUpdate.Country.ToString(),
                Traffic = statusUpdate.Traffic,
                Device = new Device
                {
                    ClassName = "Device",
                    Type = "Pointer",
                    ObjectId = session.ObjectId
                }
            };

            var content = JsonSerializer.Serialize(message);

            var result = await _restService.SendRestPostRequest(PostDeviceStatusLink, headers, content);

            return result.Status;
        }

        private class StatusUpdateMessage
        {
            [JsonPropertyName("device")]
            public Device Device { get; set; }

            [JsonPropertyName("countryIsoCode")]
            public string Country { get; set; }

            [JsonPropertyName("traffic")]
            public decimal Traffic { get; set; }
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