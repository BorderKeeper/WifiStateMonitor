using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Rest;

namespace WiFiStateMonitor.Services
{
    public class UpdateDeviceNameService : BaseService, IUpdateDeviceNameService
    {
        private const string UpdateDeviceLink = "https://parse-wandera.herokuapp.com/parse/classes/Device/{0}";

        private readonly IRestService _restService;

        public UpdateDeviceNameService()
        {
            _restService = new RestService();
        }

        public async Task<RestResponseStatus> UpdateDeviceName(RestSession session, string deviceName)
        {
            var url = string.Format(UpdateDeviceLink, session.ObjectId);
            var headers = SessionToHeaders(session);
            var content = $"{{deviceName:{deviceName}}}";

            var result = await _restService.SendRestPutRequest(url, headers, content);

            return result.Status;
        }
    }
}