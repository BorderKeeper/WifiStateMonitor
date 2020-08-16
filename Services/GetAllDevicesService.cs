using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Rest;

namespace WiFiStateMonitor.Services
{
    public class GetAllDevicesService : BaseService, IGetAllDevicesService
    {
        private const string GetAllDevicesLink = "https://parse-wandera.herokuapp.com/parse/classes/Device";

        private readonly IRestService _restService;

        public GetAllDevicesService()
        {
            _restService = new RestService();
        }

        public async Task<GetAllDevicesResult> GetAllDevices(RestSession session)
        {
            var headers = SessionToHeaders(session);

            var result = await _restService.SendRestGetRequest(GetAllDevicesLink, headers);

            if (result.Status == RestResponseStatus.Ok)
            {
                var devices = JsonSerializer.Deserialize<List<DeviceRecord>>(result.Data);

                return new GetAllDevicesResult { Devices = devices, ResponseStatus = RestResponseStatus.Ok };
            }

            return new GetAllDevicesResult { ResponseStatus = result.Status };
        }
    }
}