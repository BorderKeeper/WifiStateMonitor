using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Entities;
using WiFiStateMonitor.Api.Rest.Enums;

namespace WiFiStateMonitor.Rest
{
    public class RestService : IRestService
    {
        public async Task<RestResponse> SendRestRequest(string url, Dictionary<string, string> parameters)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var urlCompliantParameters = parameters.Select(pair => $"{pair.Key}={pair.Value}");
            HttpResponseMessage response = await client.GetAsync($"?{string.Join("&", urlCompliantParameters)}");

            if (response.IsSuccessStatusCode)
            {
                return new RestResponse
                {
                    Data = await response.Content.ReadAsStringAsync(),
                    Status = RestResponseStatus.Ok
                };
            }

            return RestResponse.ErrorResponse;
        }
    }
}