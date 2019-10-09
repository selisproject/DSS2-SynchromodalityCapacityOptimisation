using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML
{
    [XmlRoot("RecordRequest")]
    public class RecordRequest
    {
        [XmlElement("query")]
        [Newtonsoft.Json.JsonProperty("query")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.QueryOperation query
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
                                           query?._CalculatedKey?.ToString();
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
    [XmlRoot("query")]
    [Newtonsoft.Json.JsonObject(Title = "query")]
    public class QueryOperation
    {
        [XmlElement("bool")]
        [Newtonsoft.Json.JsonProperty("bool")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.BoolOperation Bool
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
                                           Bool?._CalculatedKey?.ToString();
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
    [XmlRoot("bool")]
    [Newtonsoft.Json.JsonObject(Title = "bool")]
    public class BoolOperation
    {
        [XmlElement("must")]
        [Newtonsoft.Json.JsonProperty("must")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.MustOperation must
        {
            get;
            set;
        }
        [XmlElement("filter")]
        [Newtonsoft.Json.JsonProperty("filter")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Filter filter
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
                                           must?._CalculatedKey?.ToString() +
                                           filter?._CalculatedKey?.ToString();
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
    [XmlRoot("must")]
    [Newtonsoft.Json.JsonObject(Title = "must")]
    public class MustOperation
    {
        [XmlElement("query_string")]
        [Newtonsoft.Json.JsonProperty("query_string")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.QueryString query_string
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
                                           query_string?._CalculatedKey?.ToString();
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
    [XmlRoot("query_string")]
    [Newtonsoft.Json.JsonObject(Title = "query_string")]
    public class QueryString
    {
        [XmlElement("analyze_wildcard")]
        [Newtonsoft.Json.JsonProperty("analyze_wildcard")]
        public bool analyze_wildcard
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
                                           (analyze_wildcard == true).ToString() +
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
    [XmlRoot("filter")]
    [Newtonsoft.Json.JsonObject(Title = "filter")]
    public class Filter
    {
        [XmlElement("range")]
        [Newtonsoft.Json.JsonProperty("range")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Range range
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
                                           range?._CalculatedKey?.ToString();
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
    [XmlRoot("range")]
    [Newtonsoft.Json.JsonObject(Title = "range")]
    public class Range
    {
        [XmlElement("timestamp")]
        [Newtonsoft.Json.JsonProperty("timestamp")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.Timestamp timestamp
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
                                           timestamp?._CalculatedKey?.ToString();
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
    [XmlRoot("timestamp")]
    [Newtonsoft.Json.JsonObject(Title = "timestamp")]
    public class Timestamp
    {
        [XmlElement("gte")]
        [Newtonsoft.Json.JsonProperty("gte")]
        public string gte
        {
            get;
            set;
        }
        [XmlElement("lte")]
        [Newtonsoft.Json.JsonProperty("lte")]
        public string lte
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
                                           gte?.ToString() +
                                           lte?.ToString();
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
    [XmlRoot("Results")]
    public class Results
    {
        [XmlElement("hits")]
        [Newtonsoft.Json.JsonProperty("hits")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.HitsContainer hits
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
                                           hits?._CalculatedKey?.ToString();
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
    [XmlRoot("XPackMLRoot")]
    public class XPackMLRoot
    {
        [XmlElement("_index")]
        [Newtonsoft.Json.JsonProperty("_index")]
        public string _index
        {
            get;
            set;
        }
        [XmlElement("_type")]
        [Newtonsoft.Json.JsonProperty("_type")]
        public string _type
        {
            get;
            set;
        }
        [XmlElement("_id")]
        [Newtonsoft.Json.JsonProperty("_id")]
        public string _id
        {
            get;
            set;
        }
        [XmlElement("_score")]
        [Newtonsoft.Json.JsonProperty("_score")]
        public float? _score
        {
            get;
            set;
        }
        [XmlElement("_source")]
        [Newtonsoft.Json.JsonProperty("_source")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.source source
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
                                           _index?.ToString() +
                                           _type?.ToString() +
                                           _id?.ToString() +
                                           _score?.ToString() +
                                           source?._CalculatedKey?.ToString();
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
    [XmlRoot("HitsContainer")]
    public class HitsContainer
    {
        [XmlElement("total")]
        [Newtonsoft.Json.JsonProperty("total")]
        public int? total
        {
            get;
            set;
        }
        [XmlElement("hits")]
        [Newtonsoft.Json.JsonProperty("hits")]
        public System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.XPackMLRoot> hits
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
                                           total?.ToString() +
                                           hits?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("_source")]
    [Newtonsoft.Json.JsonObject(Title = "_source")]
    public class source
    {
        [XmlElement("job_id")]
        [Newtonsoft.Json.JsonProperty("job_id")]
        public string job_id
        {
            get;
            set;
        }
        [XmlElement("result_type")]
        [Newtonsoft.Json.JsonProperty("result_type")]
        public string result_type
        {
            get;
            set;
        }
        [XmlElement("probability")]
        [Newtonsoft.Json.JsonProperty("probability")]
        public float? probability
        {
            get;
            set;
        }
        [XmlElement("record_score")]
        [Newtonsoft.Json.JsonProperty("record_score")]
        public float? record_score
        {
            get;
            set;
        }
        [XmlElement("initial_record_score")]
        [Newtonsoft.Json.JsonProperty("initial_record_score")]
        public float? initial_record_score
        {
            get;
            set;
        }
        [XmlElement("bucket_span")]
        [Newtonsoft.Json.JsonProperty("bucket_span")]
        public int? bucket_span
        {
            get;
            set;
        }
        [XmlElement("detector_index")]
        [Newtonsoft.Json.JsonProperty("detector_index")]
        public int? detector_index
        {
            get;
            set;
        }
        [XmlElement("sequence_num")]
        [Newtonsoft.Json.JsonProperty("sequence_num")]
        public int? sequence_num
        {
            get;
            set;
        }
        [XmlElement("is_interim")]
        [Newtonsoft.Json.JsonProperty("is_interim")]
        public bool is_interim
        {
            get;
            set;
        }
        [XmlElement("timestamp")]
        [Newtonsoft.Json.JsonProperty("timestamp")]
        public decimal? timestamp
        {
            get;
            set;
        }
        [XmlElement("partition_field_name")]
        [Newtonsoft.Json.JsonProperty("partition_field_name")]
        public string partition_field_name
        {
            get;
            set;
        }
        [XmlElement("partition_field_value")]
        [Newtonsoft.Json.JsonProperty("partition_field_value")]
        public string partition_field_value
        {
            get;
            set;
        }
        [XmlElement("function")]
        [Newtonsoft.Json.JsonProperty("function")]
        public string function
        {
            get;
            set;
        }
        [XmlElement("function_description")]
        [Newtonsoft.Json.JsonProperty("function_description")]
        public string function_description
        {
            get;
            set;
        }
        [XmlElement("typical")]
        [Newtonsoft.Json.JsonProperty("typical")]
        public float?[] typical
        {
            get;
            set;
        }
        [XmlElement("actual")]
        [Newtonsoft.Json.JsonProperty("actual")]
        public float?[] actual
        {
            get;
            set;
        }
        [XmlElement("influencers")]
        [Newtonsoft.Json.JsonProperty("influencers")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.XPackML.influencers[] influencers
        {
            get;
            set;
        }
        [XmlElement("Service.keyword")]
        [Newtonsoft.Json.JsonProperty("Service.keyword")]
        public string[] keyword
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
                                           job_id?.ToString() +
                                           result_type?.ToString() +
                                           probability?.ToString() +
                                           record_score?.ToString() +
                                           initial_record_score?.ToString() +
                                           bucket_span?.ToString() +
                                           detector_index?.ToString() +
                                           sequence_num?.ToString() +
                                           (is_interim == true).ToString() +
                                           timestamp?.ToString() +
                                           partition_field_name?.ToString() +
                                           partition_field_value?.ToString() +
                                           function?.ToString() +
                                           function_description?.ToString() +
                                           typical?.ToList()?.Count().ToString() +
                                           actual?.ToList()?.Count().ToString() +
                                           influencers?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           keyword?.ToList()?.Count().ToString();
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
    [XmlRoot("influencers")]
    public class influencers
    {
        [XmlElement("influencer_field_name")]
        [Newtonsoft.Json.JsonProperty("influencer_field_name")]
        public string influencer_field_name
        {
            get;
            set;
        }
        [XmlElement("influencer_field_values")]
        [Newtonsoft.Json.JsonProperty("influencer_field_values")]
        public string[] influencer_field_values
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
                                           influencer_field_name?.ToString() +
                                           influencer_field_values?.ToList()?.Count().ToString();
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
