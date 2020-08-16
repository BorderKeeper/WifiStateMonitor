using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services.Entities;

namespace WiFiStateMonitor.Api.Services
{
    public interface ICreateDeviceRecordService
    {
        Task<RestResponseStatus> CreateDeviceRecord(RestSession session, Device record);
    }
}