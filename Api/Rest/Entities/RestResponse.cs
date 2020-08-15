using WiFiStateMonitor.Api.Rest.Enums;

namespace WiFiStateMonitor.Api.Rest.Entities
{
    public class RestResponse
    {
        public static RestResponse ErrorResponse => new RestResponse { Status = RestResponseStatus.Error };

        public RestResponseStatus Status { get; set; }
        public string Data { get; set; }
    }
}