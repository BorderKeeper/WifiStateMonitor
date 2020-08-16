using System.Text.Json;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Rest;

namespace WiFiStateMonitor.Services
{
    public class GetDeviceRecordService : BaseService, IGetDeviceRecordService
    {
        private const string GetDeviceRecordLink = "https://parse-wandera.herokuapp.com/parse/classes/Device/{0}";

        private readonly IRestService _restService;

        public GetDeviceRecordService()
        {
            _restService = new RestService();
        }

        public async Task<GetDeviceRecordResult> GetDeviceRecord(RestSession session, string objectId)
        {
            var url = string.Format(GetDeviceRecordLink, objectId);
            var headers = SessionToHeaders(session);

            var result = await _restService.SendRestGetRequest(url, headers);

            if (result.Status == RestResponseStatus.Ok)
            {
                var deviceRecord = JsonSerializer.Deserialize<DeviceRecord>(result.Data);

                return new GetDeviceRecordResult { Record = deviceRecord, ResponseStatus = RestResponseStatus.Ok };
            }

            return new GetDeviceRecordResult { ResponseStatus = result.Status };
        }
    }
}