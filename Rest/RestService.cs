using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using WiFiStateMonitor.Api.Rest;
using WiFiStateMonitor.Api.Rest.Entities;
using WiFiStateMonitor.Api.Rest.Enums;

namespace WiFiStateMonitor.Rest
{
    public class RestService : IRestService
    {
        public async Task<RestResponse> SendRestGetRequest(string url, Dictionary<string, string> headers)
        {
            return await SendRestGetRequest(url, headers, new Dictionary<string, string>());
        }

        public async Task<RestResponse> SendRestGetRequest(string url, Dictionary<string, string> headers, Dictionary<string, string> parameters)
        {
            var client = SetupHttpClient(url, headers);


            var urlParameters = string.Empty;
            if (parameters.Any())
            {
                var urlCompliantParameters = parameters.Select(pair => $"{pair.Key}={HttpUtility.UrlEncode(pair.Value)}");
                urlParameters = $"?{string.Join("&", urlCompliantParameters)}";
            }
            
            HttpResponseMessage response = await client.GetAsync(urlParameters);

            if (response.IsSuccessStatusCode)
            {
                return new RestResponse
                {
                    Data = await response.Content.ReadAsStringAsync(),
                    Status = RestResponseStatus.Ok
                };
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return new RestResponse
                {
                    Status = RestResponseStatus.InvalidUsernamePassword
                };
            }

            return RestResponse.ErrorResponse;
        }

        public async Task<RestResponse> SendRestPostRequest(string url, Dictionary<string, string> headers, string content)
        {
            var client = SetupHttpClient(url, headers);

            HttpResponseMessage response = await client.PostAsync(url, new StringContent(content));

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

        public async Task<RestResponse> SendRestPutRequest(string url, Dictionary<string, string> headers, string content)
        {
            var client = SetupHttpClient(url, headers);

            HttpResponseMessage response = await client.PutAsync(url, new StringContent(content));

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

        public async Task<RestResponse> SendRestDeleteRequest(string url, Dictionary<string, string> headers)
        {
            var client = SetupHttpClient(url, headers);

            HttpResponseMessage response = await client.DeleteAsync(url);

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

        private HttpClient SetupHttpClient(string url, Dictionary<string, string> headers)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(url);

            AddHeaders(client, headers);

            return client;
        }

        private void AddHeaders(HttpClient client, Dictionary<string, string> headers)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            foreach (var header in headers)
            {
                client.DefaultRequestHeaders.Add(header.Key, new List<string> { header.Value });
            }
        }
    }
}