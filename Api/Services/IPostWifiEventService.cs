using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Api.Services.Enums;

namespace WiFiStateMonitor.Api.Services
{
    public interface IPostWifiEventService
    {
        Task<RestResponseStatus> PostWifiEvent(RestSession session, WifiEvent wifiEvent);
    }
}