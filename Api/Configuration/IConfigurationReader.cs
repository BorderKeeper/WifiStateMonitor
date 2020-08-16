using WiFiStateMonitor.Api.Configuration.Entities;

namespace WiFiStateMonitor.Api.Configuration
{
    public interface IConfigurationReader
    {
        RestConfiguration GetRestConfiguration();
    }
}