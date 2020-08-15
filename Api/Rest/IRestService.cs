using System.Collections.Generic;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest.Entities;

namespace WiFiStateMonitor.Api.Rest
{
    public interface IRestService
    {
        Task<RestResponse> SendRestRequest(string url, Dictionary<string, string> parameters);
    }
}