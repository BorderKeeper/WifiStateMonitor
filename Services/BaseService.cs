using System.Collections.Generic;
using WiFiStateMonitor.Api.Configuration.Entities;
using WiFiStateMonitor.Api.Services.Entities;

namespace WiFiStateMonitor.Services
{
    public class BaseService
    {
        protected Dictionary<string, string> LoginConfigurationToHeaders(RestConfiguration configuration)
        {
            return new Dictionary<string, string>
            {
                { "X-Parse-REST-API-Key", configuration.RestApiKey },
                { "X-Parse-Application-Id", configuration.ApplicationId }
            };
        }

        protected Dictionary<string, string> SessionToHeaders(RestSession session)
        {
            var headers = LoginConfigurationToHeaders(session.Configuration);

            headers.Add("X-Parse-Session-Token", session.SessionToken);

            return headers;
        }
    }
}