using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.LocalPubSub
{
    [XmlRoot("LocalPubSubRoot")]
    [Newtonsoft.Json.JsonObject(Title = "LocalPubSubRoot")]
    public class LocalPubSubSubscribeRoot
    {
        [XmlElement("key")]
        [Newtonsoft.Json.JsonProperty("key")]
        public string key
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
        [XmlElement("val")]
        [Newtonsoft.Json.JsonProperty("val")]
        public string val
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
                                           key?.ToString() +
                                           type?.ToString() +
                                           val?.ToString();
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
    [XmlRoot("SubRoot")]
    public class SubRoot
    {
        [XmlElement("authHash")]
        [Newtonsoft.Json.JsonProperty("authHash")]
        public string authHash
        {
            get;
            set;
        }
        [XmlElement("subscriptionId")]
        [Newtonsoft.Json.JsonProperty("subscriptionId")]
        public string subscriptionId
        {
            get;
            set;
        }
        [XmlElement("data")]
        [Newtonsoft.Json.JsonProperty("data")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.LocalPubSub.SubRule[] data
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
                                           authHash?.ToString() +
                                           subscriptionId?.ToString() +
                                           data?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("SubRule")]
    public class SubRule
    {
        [XmlElement("key")]
        [Newtonsoft.Json.JsonProperty("key")]
        public string key
        {
            get;
            set;
        }
        [XmlElement("val")]
        [Newtonsoft.Json.JsonProperty("val")]
        public int? val
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
        [XmlElement("op")]
        [Newtonsoft.Json.JsonProperty("op")]
        public string op
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
                                           key?.ToString() +
                                           val?.ToString() +
                                           type?.ToString() +
                                           op?.ToString();
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
    [XmlRoot("SubscribeResult")]
    public class SubscribeResult
    {
        [XmlElement("host")]
        [Newtonsoft.Json.JsonProperty("host")]
        public string host
        {
            get;
            set;
        }
        [XmlElement("port")]
        [Newtonsoft.Json.JsonProperty("port")]
        public int? port
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
                                           host?.ToString() +
                                           port?.ToString();
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
    [XmlRoot("Publication")]
    public class Publication
    {
        [XmlElement("publication")]
        [Newtonsoft.Json.JsonProperty("publication")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.LocalPubSub.PubMessage[] publication
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
                                           publication?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("PubMessage")]
    public class PubMessage
    {
        [XmlElement("key")]
        [Newtonsoft.Json.JsonProperty("key")]
        public string key
        {
            get;
            set;
        }
        [XmlElement("val")]
        [Newtonsoft.Json.JsonProperty("val")]
        public string val
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
                                           key?.ToString() +
                                           val?.ToString() +
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
