using System.Threading.Tasks;
using WiFiStateMonitor.Api.Services.Entities;

namespace WiFiStateMonitor.Api.Services
{
    public interface IGetDeviceRecordService
    {
        Task<GetDeviceRecordResult> GetDeviceRecord(RestSession session, string objectId);
    }
}