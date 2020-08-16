using System.Security;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Api.Services.Enums;
using WiFiStateMonitor.Configuration;

namespace WiFiStateMonitor.Services
{
    public class ConnectionHandler : IConnectionHandler
    {
        private readonly ILoginService _loginService;

        private RestSession _session;

        private LoginStatus _lastLoginStatus = LoginStatus.Unknown;

        public ConnectionHandler()
        {
            _session = new RestSession();
            _loginService = new LoginService();

            var configurationReader = new ConfigurationReader();
            _session.Configuration = configurationReader.GetRestConfiguration();
        }

        public async Task<LoginStatus> Connect(string username, string password)
        {
            var result = await _loginService.Login(_session.Configuration, username, password);

            if (result.ResultStatus == LoginStatus.Successful)
            {
                _session = result.Session;
            }

            _lastLoginStatus = result.ResultStatus;
            return result.ResultStatus;
        }

        public void Disconnect()
        {
            _session.SessionToken = string.Empty;
        }

        public bool IsConnected()
        {
            return _lastLoginStatus == LoginStatus.Successful;
        }

        public RestSession GetSession()
        {
            return _session;
        }
    }
}