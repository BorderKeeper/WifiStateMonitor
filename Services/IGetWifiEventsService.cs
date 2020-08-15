using System.Collections.Generic;
using System.Threading.Tasks;
using WiFiStateMonitor.Entities;

namespace WiFiStateMonitor.Services
{
    public interface IGetWifiEventsService
    {
        Task<IEnumerable<WifiEvent>> GetEvents();
    }
}