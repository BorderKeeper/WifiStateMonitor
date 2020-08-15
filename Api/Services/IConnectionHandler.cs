using System.Security;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Services.Enums;

namespace WiFiStateMonitor.Api.Services
{
    public interface IConnectionHandler
    {
        Task<LoginResult> Connect(string username, SecureString password);

        void Disconnect();

        bool IsConnected();
    }
}