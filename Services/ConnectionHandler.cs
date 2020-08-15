using System.Security;
using System.Threading.Tasks;
using WiFiStateMonitor.Services.Enums;

namespace WiFiStateMonitor.Services
{
    public class ConnectionHandler : IConnectionHandler
    {
        public Task<LoginResult> Connect(string username, SecureString password)
        {
            return Task.FromResult(LoginResult.Successful);
        }

        public void Disconnect()
        {

        }

        public bool IsConnected()
        {
            return true;
        }
    }
}