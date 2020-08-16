using System.Threading.Tasks;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Api.Services.Enums;

namespace WiFiStateMonitor.Api.Services
{
    public interface IConnectionHandler
    {
        Task<LoginStatus> Connect(string username, string password);

        void Disconnect();

        bool IsConnected();

        RestSession GetSession();
    }
}