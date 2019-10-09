using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.DisruptionAPI
{
    [XmlRoot("TrucksRecommended")]
    public class TrucksRecommended
    {
        [XmlElement("order_id")]
        [Newtonsoft.Json.JsonProperty("order_id")]
        public string order_id
        {
            get;
            set;
        }
        [XmlElement("trucks_recommended")]
        [Newtonsoft.Json.JsonProperty("trucks_recommended")]
        public string[] trucks_recommended
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
                                           order_id?.ToString() +
                                           trucks_recommended?.ToList()?.Count().ToString();
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
