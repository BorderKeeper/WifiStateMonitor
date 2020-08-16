using System.Collections.Generic;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest.Entities;

namespace WiFiStateMonitor.Api.Rest
{
    public interface IRestService
    {
        Task<RestResponse> SendRestGetRequest(string url, Dictionary<string, string> headers, Dictionary<string, string> parameters);

        Task<RestResponse> SendRestGetRequest(string url, Dictionary<string, string> headers);

        Task<RestResponse> SendRestPostRequest(string url, Dictionary<string, string> headers, string content);

        Task<RestResponse> SendRestPutRequest(string url, Dictionary<string, string> headers, string content);

        Task<RestResponse> SendRestDeleteRequest(string url, Dictionary<string, string> headers);
    }
}