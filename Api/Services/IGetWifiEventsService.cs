using System.Threading.Tasks;
using WiFiStateMonitor.Api.Services.Entities;

namespace WiFiStateMonitor.Api.Services
{
    public interface IGetWifiEventsService
    {
        Task<GetWifiEventsResult> GetEvents(RestSession session, string objectId);
    }
}