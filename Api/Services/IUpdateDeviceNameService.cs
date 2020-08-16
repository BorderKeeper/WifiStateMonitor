using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services.Entities;

namespace WiFiStateMonitor.Api.Services
{
    public interface IUpdateDeviceNameService
    {
        Task<RestResponseStatus> UpdateDeviceName(RestSession session, string deviceName);
    }
}