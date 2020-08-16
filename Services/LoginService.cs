using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Configuration.Entities;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Enums;
using WiFiStateMonitor.Api.Services;
using WiFiStateMonitor.Api.Services.Entities;
using WiFiStateMonitor.Api.Services.Enums;
using WiFiStateMonitor.Rest;

namespace WiFiStateMonitor.Services
{
    public class LoginService : BaseService, ILoginService
    {
        private const string LoginUrl = "https://parse-wandera.herokuapp.com/parse/login";

        private readonly IRestService _restService;

        public LoginService()
        {
            _restService = new RestService();
        }

        public async Task<LoginResult> Login(RestConfiguration configuration, string username, string password)
        {
            var configurationHeaders = LoginConfigurationToHeaders(configuration);

            var loginParameters = new Dictionary<string, string>
            {
                { "username", username },
                { "password", password }
            };

            var loginResponse = await _restService.SendRestGetRequest(LoginUrl, configurationHeaders, loginParameters);

            if (loginResponse.Status == RestResponseStatus.Ok)
            {
                return new LoginResult
                {
                    ResultStatus = LoginStatus.Successful,
                    Session = ParseRestSession(loginResponse.Data, configuration)
                };
            }

            return new LoginResult { ResultStatus = LoginStatus.Unknown };
        }

        private RestSession ParseRestSession(string data, RestConfiguration configuration)
        {
            var session = JsonSerializer.Deserialize<RestSession>(data);
            session.Configuration = configuration;

            return session;
        }
    }
}