using System.Threading.Tasks;
using WiFiStateMonitor.Api.Services.Entities;

namespace WiFiStateMonitor.Api.Services
{
    public interface IGetAllDevicesService
    {
        Task<GetAllDevicesResult> GetAllDevices(RestSession session);
    }
}