using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Rest;

namespace WiFiStateMonitor.Services
{
    public class DeleteDeviceService : BaseService, IDeleteDeviceService
    {
        private const string DeleteDeviceLink = "https://parse-wandera.herokuapp.com/parse/classes/Device/{0}";

        private IRestService _restService;

        public DeleteDeviceService()
        {
            _restService = new RestService();
        }

        public async Task<RestResponseStatus> DeleteDevice(RestSession session, string objectId)
        {
            var url = string.Format(DeleteDeviceLink, objectId);
            var headers = SessionToHeaders(session);

            var result = await _restService.SendRestDeleteRequest(url, headers);

            return result.Status;
        }
    }
}