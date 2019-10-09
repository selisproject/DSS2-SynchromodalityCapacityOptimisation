using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Mapotempo
{
    [XmlRoot("MapotempoRoot")]
    public class MapotempoRoot
    {
        [XmlElement("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public string type
        {
            get;
            set;
        }
        [XmlElement("geocoding")]
        [Newtonsoft.Json.JsonProperty("geocoding")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Mapotempo.geocoding geocoding
        {
            get;
            set;
        }
        [XmlElement("features")]
        [Newtonsoft.Json.JsonProperty("features")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Mapotempo.features[] features
        {
            get;
            set;
        }
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-" +
                                           type?.ToString() +
                                           geocoding?._CalculatedKey?.ToString() +
                                           features?.Sum(x => x?._CalculatedKey)?.ToString();
                    return allPropsConcated.GetHashCode();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set {}
        }
    }
    [XmlRoot("geocoding")]
    public class geocoding
    {
        [XmlElement("version")]
        [Newtonsoft.Json.JsonProperty("version")]
        public string version
        {
            get;
            set;
        }
        [XmlElement("licence")]
        [Newtonsoft.Json.JsonProperty("licence")]
        public string licence
        {
            get;
            set;
        }
        [XmlElement("attribution")]
        [Newtonsoft.Json.JsonProperty("attribution")]
        public string attribution
        {
            get;
            set;
        }
        [XmlElement("query")]
        [Newtonsoft.Json.JsonProperty("query")]
        public string query
        {
            get;
            set;
        }
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-" +
                                           version?.ToString() +
                                           licence?.ToString() +
                                           attribution?.ToString() +
                                           query?.ToString();
                    return allPropsConcated.GetHashCode();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set {}
        }
    }
    [XmlRoot("features")]
    public class features
    {
        [XmlElement("properties")]
        [Newtonsoft.Json.JsonProperty("properties")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Mapotempo.properties properties
        {
            get;
            set;
        }
        [XmlElement("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public string type
        {
            get;
            set;
        }
        [XmlElement("geometry")]
        [Newtonsoft.Json.JsonProperty("geometry")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Mapotempo.geometry geometry
        {
            get;
            set;
        }
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-" +
                                           properties?._CalculatedKey?.ToString() +
                                           type?.ToString() +
                                           geometry?._CalculatedKey?.ToString();
                    return allPropsConcated.GetHashCode();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set {}
        }
    }
    [XmlRoot("properties")]
    public class properties
    {
        [XmlElement("geocoding")]
        [Newtonsoft.Json.JsonProperty("geocoding")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Mapotempo.propertiesGeocoding geocoding
        {
            get;
            set;
        }
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-" +
                                           geocoding?._CalculatedKey?.ToString();
                    return allPropsConcated.GetHashCode();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set {}
        }
    }
    [XmlRoot("propertiesGeocoding")]
    public class propertiesGeocoding
    {
        [XmlElement("score")]
        [Newtonsoft.Json.JsonProperty("score")]
        public float? score
        {
            get;
            set;
        }
        [XmlElement("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public string type
        {
            get;
            set;
        }
        [XmlElement("label")]
        [Newtonsoft.Json.JsonProperty("label")]
        public string label
        {
            get;
            set;
        }
        [XmlElement("postcode")]
        [Newtonsoft.Json.JsonProperty("postcode")]
        public string postcode
        {
            get;
            set;
        }
        [XmlElement("city")]
        [Newtonsoft.Json.JsonProperty("city")]
        public string city
        {
            get;
            set;
        }
        [XmlElement("county")]
        [Newtonsoft.Json.JsonProperty("county")]
        public string county
        {
            get;
            set;
        }
        [XmlElement("state")]
        [Newtonsoft.Json.JsonProperty("state")]
        public string state
        {
            get;
            set;
        }
        [XmlElement("country")]
        [Newtonsoft.Json.JsonProperty("country")]
        public string country
        {
            get;
            set;
        }
        [XmlElement("housenumber")]
        [Newtonsoft.Json.JsonProperty("housenumber")]
        public string housenumber
        {
            get;
            set;
        }
        [XmlElement("street")]
        [Newtonsoft.Json.JsonProperty("street")]
        public string street
        {
            get;
            set;
        }
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-" +
                                           score?.ToString() +
                                           type?.ToString() +
                                           label?.ToString() +
                                           postcode?.ToString() +
                                           city?.ToString() +
                                           county?.ToString() +
                                           state?.ToString() +
                                           country?.ToString() +
                                           housenumber?.ToString() +
                                           street?.ToString();
                    return allPropsConcated.GetHashCode();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set {}
        }
    }
    [XmlRoot("geometry")]
    public class geometry
    {
        [XmlElement("coordinates")]
        [Newtonsoft.Json.JsonProperty("coordinates")]
        public float?[] coordinates
        {
            get;
            set;
        }
        [XmlElement("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public string type
        {
            get;
            set;
        }
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-" +
                                           coordinates?.ToList()?.Count().ToString() +
                                           type?.ToString();
                    return allPropsConcated.GetHashCode();
                }
                catch (Exception)
                {
                    return 0;
                }
            }
            set {}
        }
    }
}
