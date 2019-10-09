using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode
{
    [XmlRoot("Root")]
    public class Root
    {
        [XmlElement("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public string status
        {
            get;
            set;
        }
        [XmlElement("results")]
        [Newtonsoft.Json.JsonProperty("results")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.result[] results
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
                                           status?.ToString() +
                                           results?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("result")]
    public class result
    {
        [XmlElement("formatted_address")]
        [Newtonsoft.Json.JsonProperty("formatted_address")]
        public string formatted_address
        {
            get;
            set;
        }
        [XmlElement("place_id")]
        [Newtonsoft.Json.JsonProperty("place_id")]
        public string place_id
        {
            get;
            set;
        }
        [XmlElement("types")]
        [Newtonsoft.Json.JsonProperty("types")]
        public string[] types
        {
            get;
            set;
        }
        [XmlElement("address_components")]
        [Newtonsoft.Json.JsonProperty("address_components")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.address_component[] address_components
        {
            get;
            set;
        }
        [XmlElement("geometry")]
        [Newtonsoft.Json.JsonProperty("geometry")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.geometry geometry
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
                                           formatted_address?.ToString() +
                                           place_id?.ToString() +
                                           types?.ToList()?.Count().ToString() +
                                           address_components?.Sum(x => x?._CalculatedKey)?.ToString() +
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
    [XmlRoot("address_component")]
    public class address_component
    {
        [XmlElement("long_name")]
        [Newtonsoft.Json.JsonProperty("long_name")]
        public string long_name
        {
            get;
            set;
        }
        [XmlElement("short_name")]
        [Newtonsoft.Json.JsonProperty("short_name")]
        public string short_name
        {
            get;
            set;
        }
        [XmlElement("types")]
        [Newtonsoft.Json.JsonProperty("types")]
        public string[] types
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
                                           long_name?.ToString() +
                                           short_name?.ToString() +
                                           types?.ToList()?.Count().ToString();
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
        [XmlElement("location_type")]
        [Newtonsoft.Json.JsonProperty("location_type")]
        public string location_type
        {
            get;
            set;
        }
        [XmlElement("location")]
        [Newtonsoft.Json.JsonProperty("location")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.location location
        {
            get;
            set;
        }
        [XmlElement("viewport")]
        [Newtonsoft.Json.JsonProperty("viewport")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.viewport viewport
        {
            get;
            set;
        }
        [XmlElement("bounds")]
        [Newtonsoft.Json.JsonProperty("bounds")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.viewport bounds
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
                                           location_type?.ToString() +
                                           location?._CalculatedKey?.ToString() +
                                           viewport?._CalculatedKey?.ToString() +
                                           bounds?._CalculatedKey?.ToString();
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
    [XmlRoot("location")]
    public class location
    {
        [XmlElement("lat")]
        [Newtonsoft.Json.JsonProperty("lat")]
        public string lat
        {
            get;
            set;
        }
        [XmlElement("lng")]
        [Newtonsoft.Json.JsonProperty("lng")]
        public string lng
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
                                           lat?.ToString() +
                                           lng?.ToString();
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
    [XmlRoot("viewport")]
    public class viewport
    {
        [XmlElement("northeast")]
        [Newtonsoft.Json.JsonProperty("northeast")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.location northeast
        {
            get;
            set;
        }
        [XmlElement("southwest")]
        [Newtonsoft.Json.JsonProperty("southwest")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleGeocode.location southwest
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
                                           northeast?._CalculatedKey?.ToString() +
                                           southwest?._CalculatedKey?.ToString();
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
