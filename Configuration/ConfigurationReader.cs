using WiFiStateMonitor.Api.Configuration;
using WiFiStateMonitor.Api.Configuration.Entities;

namespace WiFiStateMonitor.Configuration
{
    public class ConfigurationReader : IConfigurationReader
    {
        public RestConfiguration GetRestConfiguration()
        {
            return new RestConfiguration
            {
                //TODO: read from .env file
                ApplicationId = "UKB9QAriw4ABOGRwOJ67fXj2Iypx7UQPhj5ZdR66",
                RestApiKey = "FQ3wONUU2tFb7o8I7nszpAlQkMoxMS6FEbcpXkRz"
            };
        }
    }
}