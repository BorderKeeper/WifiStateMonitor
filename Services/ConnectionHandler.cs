using System.Security;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Api.Services.Enums;

namespace WiFiStateMonitor.Services
{
    public class ConnectionHandler : IConnectionHandler
    {
        private IRestService _restService;

        private RestSession _session;

        public ConnectionHandler()
        {
            //TODO: Load two values from .env file
        }

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