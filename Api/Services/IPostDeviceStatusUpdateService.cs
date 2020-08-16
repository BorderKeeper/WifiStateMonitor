using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services.Entities;

namespace WiFiStateMonitor.Api.Services
{
    public interface IPostDeviceStatusUpdateService
    {
        Task<RestResponseStatus> PostDeviceStatusUpdate(RestSession session, DeviceStatusUpdate statusUpdate);
    }
}