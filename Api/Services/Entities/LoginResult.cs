using WiFiStateMonitor.Api.Services.Enums;

namespace WiFiStateMonitor.Api.Services.Entities
{
    public class LoginResult
    {
        public LoginStatus ResultStatus { get; set; }

        public RestSession Session { get; set; }
    }
}