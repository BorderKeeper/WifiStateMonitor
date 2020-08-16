using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services.Entities;

namespace WiFiStateMonitor.Api.Services
{
    public interface IDeleteDeviceService
    {
        Task<RestResponseStatus> DeleteDevice(RestSession session, string objectId);
    }
}