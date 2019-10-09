using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo
{
    [XmlRoot("Router_MapotempoRoot")]
    public class Router_MapotempoRoot
    {
        [XmlElement("type")]
        [Newtonsoft.Json.JsonProperty("type")]
        public string type
        {
            get;
            set;
        }
        [XmlElement("router")]
        [Newtonsoft.Json.JsonProperty("router")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo.router router
        {
            get;
            set;
        }
        [XmlElement("features")]
        [Newtonsoft.Json.JsonProperty("features")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo.features[] features
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
                                           router?._CalculatedKey?.ToString() +
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
    [XmlRoot("router")]
    public class router
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
                                           attribution?.ToString();
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
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo.properties properties
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
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo.geometry geometry
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
        [XmlElement("router")]
        [Newtonsoft.Json.JsonProperty("router")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Router_Mapotempo.propertiesRouter router
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
                                           router?._CalculatedKey?.ToString();
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
    [XmlRoot("propertiesRouter")]
    public class propertiesRouter
    {
        [XmlElement("total_distance")]
        [Newtonsoft.Json.JsonProperty("total_distance")]
        public decimal? total_distance
        {
            get;
            set;
        }
        [XmlElement("total_time")]
        [Newtonsoft.Json.JsonProperty("total_time")]
        public decimal? total_time
        {
            get;
            set;
        }
        [XmlElement("start_point")]
        [Newtonsoft.Json.JsonProperty("start_point")]
        public decimal?[] start_point
        {
            get;
            set;
        }
        [XmlElement("end_point")]
        [Newtonsoft.Json.JsonProperty("end_point")]
        public decimal?[] end_point
        {
            get;
            set;
        }
        [XmlElement("total_toll_costs")]
        [Newtonsoft.Json.JsonProperty("total_toll_costs")]
        public decimal? total_toll_costs
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
                                           total_distance?.ToString() +
                                           total_time?.ToString() +
                                           start_point?.ToList()?.Count().ToString() +
                                           end_point?.ToList()?.Count().ToString() +
                                           total_toll_costs?.ToString();
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
        public int?[] coordinates
        {
            get;
            set;
        }
        [XmlElement("polylines")]
        [Newtonsoft.Json.JsonProperty("polylines")]
        public string polylines
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
                                           polylines?.ToString() +
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
