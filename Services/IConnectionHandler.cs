using System.Security;
using System.Threading.Tasks;
using WiFiStateMonitor.Services.Enums;

namespace WiFiStateMonitor.Services
{
    public interface IConnectionHandler
    {
        Task<LoginResult> Connect(string username, SecureString password);

        void Disconnect();

        bool IsConnected();
    }
}