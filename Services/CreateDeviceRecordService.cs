using System.Text.Json;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Rest;

namespace WiFiStateMonitor.Services
{
    public class CreateDeviceRecordService : BaseService, ICreateDeviceRecordService
    {
        private const string CreateDeviceUrl = "https://parse-wandera.herokuapp.com/parse/classes/Device";

        private readonly IRestService _restService;

        public CreateDeviceRecordService()
        {
            _restService = new RestService();
        }

        public async Task<RestResponseStatus> CreateDeviceRecord(RestSession session, Device record)
        {
            var headers = SessionToHeaders(session);

            var content = JsonSerializer.Serialize(record);

            var result = await _restService.SendRestPostRequest(CreateDeviceUrl, headers, content);

            return result.Status;
        }
    }
}