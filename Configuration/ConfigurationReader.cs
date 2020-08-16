using System.Configuration;
using System.IO;
using System.Xml.Serialization;
using WiFiStateMonitor.Api.Configuration;
using WiFiStateMonitor.Api.Configuration.Entities;

namespace WiFiStateMonitor.Configuration
{
    public class ConfigurationReader : IConfigurationReader
    {
        private const string ConfigurationPath = ".env";

        public RestConfiguration GetRestConfiguration()
        {
            if (!File.Exists(ConfigurationPath))
            {
                throw new ConfigurationErrorsException(".env file is missing");
            }

            XmlSerializer serializer = new XmlSerializer(typeof(RestConfiguration));

            using (StreamReader reader = new StreamReader(ConfigurationPath))
            {
                var configuration = serializer.Deserialize(reader) as RestConfiguration;

                return configuration;
            }
        }
    }
}