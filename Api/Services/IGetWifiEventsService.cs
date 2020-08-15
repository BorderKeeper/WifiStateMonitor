using System.Collections.Generic;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Services.Enums;

namespace WiFiStateMonitor.Api.Services
{
    public interface IGetWifiEventsService
    {
        Task<IEnumerable<WifiEvent>> GetEvents();
    }
}