using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDistanceMatrixAPI
{
    [XmlRoot("GoogleDistanceMatrixAPIRoot")]
    public class GoogleDistanceMatrixAPIRoot
    {
        [XmlElement("destination_addresses")]
        [Newtonsoft.Json.JsonProperty("destination_addresses")]
        public string[] destination_addresses
        {
            get;
            set;
        }
        [XmlElement("origin_addresses")]
        [Newtonsoft.Json.JsonProperty("origin_addresses")]
        public string[] origin_addresses
        {
            get;
            set;
        }
        [XmlElement("rows")]
        [Newtonsoft.Json.JsonProperty("rows")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDistanceMatrixAPI.rows[] rows
        {
            get;
            set;
        }
        [XmlElement("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public string status
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
                                           destination_addresses?.ToList()?.Count().ToString() +
                                           origin_addresses?.ToList()?.Count().ToString() +
                                           rows?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           status?.ToString();
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
    [XmlRoot("rows")]
    public class rows
    {
        [XmlElement("elements")]
        [Newtonsoft.Json.JsonProperty("elements")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDistanceMatrixAPI.elements[] elements
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
                                           elements?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("elements")]
    public class elements
    {
        [XmlElement("distance")]
        [Newtonsoft.Json.JsonProperty("distance")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDistanceMatrixAPI.distance distance
        {
            get;
            set;
        }
        [XmlElement("duration")]
        [Newtonsoft.Json.JsonProperty("duration")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDistanceMatrixAPI.duration duration
        {
            get;
            set;
        }
        [XmlElement("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public string status
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
                                           distance?._CalculatedKey?.ToString() +
                                           duration?._CalculatedKey?.ToString() +
                                           status?.ToString();
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
    [XmlRoot("distance")]
    public class distance
    {
        [XmlElement("text")]
        [Newtonsoft.Json.JsonProperty("text")]
        public string text
        {
            get;
            set;
        }
        [XmlElement("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public int? value
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
                                           text?.ToString() +
                                           value?.ToString();
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
    [XmlRoot("duration")]
    public class duration
    {
        [XmlElement("text")]
        [Newtonsoft.Json.JsonProperty("text")]
        public string text
        {
            get;
            set;
        }
        [XmlElement("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public int? value
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
                                           text?.ToString() +
                                           value?.ToString();
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
