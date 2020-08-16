using System;
using System.Xml.Serialization;

namespace WiFiStateMonitor.Api.Configuration.Entities
{
    [Serializable]
    [XmlRoot("configuration")]
    public class RestConfiguration
    {
        [XmlElement("applicationId")]
        public string ApplicationId { get; set; }

        [XmlElement("restApiKey")]
        public string RestApiKey { get; set; }
    }
}