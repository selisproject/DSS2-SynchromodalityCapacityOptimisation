using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch
{
    [XmlRoot("terms")]
    [Newtonsoft.Json.JsonObject(Title = "terms")]
    public class TermAggregator
    {
        [XmlElement("field")]
        [Newtonsoft.Json.JsonProperty("field")]
        public string field
        {
            get;
            set;
        }
        [XmlElement("size")]
        [Newtonsoft.Json.JsonProperty("size")]
        public int? size
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
                                           field?.ToString() +
                                           size?.ToString();
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
    [XmlRoot("terms")]
    [Newtonsoft.Json.JsonObject(Title = "terms")]
    public class TermAggregatorRoot
    {
        [XmlElement("terms")]
        [Newtonsoft.Json.JsonProperty("terms")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregator terms
        {
            get;
            set;
        }
        [XmlElement("aggs")]
        [Newtonsoft.Json.JsonProperty("aggs")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermsAggregationRequest Aggs
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
                                           terms?._CalculatedKey?.ToString() +
                                           Aggs?._CalculatedKey?.ToString();
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
    [XmlRoot("Order")]
    [Newtonsoft.Json.JsonObject(Title = "Order")]
    public class TermsAggregationRequest
    {
        [XmlElement("order")]
        [Newtonsoft.Json.JsonProperty("order")]
        public string order
        {
            get;
            set;
        }
        [XmlElement("resposeStatus")]
        [Newtonsoft.Json.JsonProperty("resposeStatus")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.ErrorFilterAgg ResposeStatus
        {
            get;
            set;
        }
        [XmlElement("responseTime")]
        [Newtonsoft.Json.JsonProperty("responseTime")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregatorRoot ResponseTime
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
                                           order?.ToString() +
                                           ResposeStatus?._CalculatedKey?.ToString() +
                                           ResponseTime?._CalculatedKey?.ToString();
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
    [XmlRoot("stats")]
    [Newtonsoft.Json.JsonObject(Title = "stats")]
    public class StatsAggregator
    {
        [XmlElement("field")]
        [Newtonsoft.Json.JsonProperty("field")]
        public string field
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
                                           field?.ToString();
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
    [XmlRoot("stats")]
    [Newtonsoft.Json.JsonObject(Title = "stats")]
    public class StatsAggregatorRoot
    {
        [XmlElement("stats")]
        [Newtonsoft.Json.JsonProperty("stats")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregator stats
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
                                           stats?._CalculatedKey?.ToString();
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
    [XmlRoot("AnalyticsRequest")]
    public class AnalyticsRequest
    {
        [XmlElement("query")]
        [Newtonsoft.Json.JsonProperty("query")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Query query
        {
            get;
            set;
        }
        [XmlElement("aggs")]
        [Newtonsoft.Json.JsonProperty("aggs")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.OBAggregatorRequest aggs
        {
            get;
            set;
        }
        [XmlElement("_source")]
        [Newtonsoft.Json.JsonProperty("_source")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Meta source
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
                                           query?._CalculatedKey?.ToString() +
                                           aggs?._CalculatedKey?.ToString() +
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
    [XmlRoot("SearchRequest")]
    public class SearchRequest
    {
        [XmlElement("_source")]
        [Newtonsoft.Json.JsonProperty("_source")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Meta source
        {
            get;
            set;
        }
        [XmlElement("query")]
        [Newtonsoft.Json.JsonProperty("query")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Query query
        {
            get;
            set;
        }
        [XmlElement("sort")]
        [Newtonsoft.Json.JsonProperty("sort")]
        public System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Sort> sort
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
                                           source?._CalculatedKey?.ToString() +
                                           query?._CalculatedKey?.ToString() +
                                           sort?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("OBAggregatorRequest")]
    public class OBAggregatorRequest
    {
        [XmlElement("elapsed_msecs")]
        [Newtonsoft.Json.JsonProperty("elapsed_msecs")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregatorRoot ElapsedMsecs
        {
            get;
            set;
        }
        [XmlElement("top_service")]
        [Newtonsoft.Json.JsonProperty("top_service")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot TopService
        {
            get;
            set;
        }
        [XmlElement("top_operation")]
        [Newtonsoft.Json.JsonProperty("top_operation")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot TopOperation
        {
            get;
            set;
        }
        [XmlElement("from_ip")]
        [Newtonsoft.Json.JsonProperty("from_ip")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot FromIP
        {
            get;
            set;
        }
        [XmlElement("verb_type")]
        [Newtonsoft.Json.JsonProperty("verb_type")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot VerbType
        {
            get;
            set;
        }
        [XmlElement("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot Status
        {
            get;
            set;
        }
        [XmlElement("req_over_time")]
        [Newtonsoft.Json.JsonProperty("req_over_time")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.HistogramRoot RequestOverTime
        {
            get;
            set;
        }
        [XmlElement("req_latency")]
        [Newtonsoft.Json.JsonProperty("req_latency")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.BucketHistogramRoot RequestLatency
        {
            get;
            set;
        }
        [XmlElement("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.ErrorFilterAgg Errors
        {
            get;
            set;
        }
        [XmlElement("services")]
        [Newtonsoft.Json.JsonProperty("services")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot Services
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
                                           ElapsedMsecs?._CalculatedKey?.ToString() +
                                           TopService?._CalculatedKey?.ToString() +
                                           TopOperation?._CalculatedKey?.ToString() +
                                           FromIP?._CalculatedKey?.ToString() +
                                           VerbType?._CalculatedKey?.ToString() +
                                           Status?._CalculatedKey?.ToString() +
                                           RequestOverTime?._CalculatedKey?.ToString() +
                                           RequestLatency?._CalculatedKey?.ToString() +
                                           Errors?._CalculatedKey?.ToString() +
                                           Services?._CalculatedKey?.ToString();
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
    [XmlRoot("OBAggregatorResponse")]
    public class OBAggregatorResponse
    {
        [XmlElement("elapsed_msecs")]
        [Newtonsoft.Json.JsonProperty("elapsed_msecs")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregatorResponse ElapsedMsecs
        {
            get;
            set;
        }
        [XmlElement("top_service")]
        [Newtonsoft.Json.JsonProperty("top_service")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorResponse TopService
        {
            get;
            set;
        }
        [XmlElement("top_operation")]
        [Newtonsoft.Json.JsonProperty("top_operation")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorResponse TopOperation
        {
            get;
            set;
        }
        [XmlElement("from_ip")]
        [Newtonsoft.Json.JsonProperty("from_ip")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorResponse FromIP
        {
            get;
            set;
        }
        [XmlElement("verb_type")]
        [Newtonsoft.Json.JsonProperty("verb_type")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorResponse VerbType
        {
            get;
            set;
        }
        [XmlElement("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorResponse Status
        {
            get;
            set;
        }
        [XmlElement("req_over_time")]
        [Newtonsoft.Json.JsonProperty("req_over_time")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.HistogramResponse RequestOverTime
        {
            get;
            set;
        }
        [XmlElement("req_latency")]
        [Newtonsoft.Json.JsonProperty("req_latency")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.HistogramResponse RequestLatency
        {
            get;
            set;
        }
        [XmlElement("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.ErrorFilterAggResponse Errors
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
                                           ElapsedMsecs?._CalculatedKey?.ToString() +
                                           TopService?._CalculatedKey?.ToString() +
                                           TopOperation?._CalculatedKey?.ToString() +
                                           FromIP?._CalculatedKey?.ToString() +
                                           VerbType?._CalculatedKey?.ToString() +
                                           Status?._CalculatedKey?.ToString() +
                                           RequestOverTime?._CalculatedKey?.ToString() +
                                           RequestLatency?._CalculatedKey?.ToString() +
                                           Errors?._CalculatedKey?.ToString();
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
    [XmlRoot("SearchResponse")]
    public class SearchResponse
    {
        [XmlElement("hits")]
        [Newtonsoft.Json.JsonProperty("hits")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.HitsResponse HitResponce
        {
            get;
            set;
        }
        [XmlElement("took")]
        [Newtonsoft.Json.JsonProperty("took")]
        public int? Took
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
                                           HitResponce?._CalculatedKey?.ToString() +
                                           Took?.ToString();
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
    [XmlRoot("AnalyticsResponse")]
    public class AnalyticsResponse
    {
        [XmlElement("aggregations")]
        [Newtonsoft.Json.JsonProperty("aggregations")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.OBAggregatorResponse aggregations
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
                                           aggregations?._CalculatedKey?.ToString();
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
    [XmlRoot("DocumentCount")]
    [Newtonsoft.Json.JsonObject(Title = "DocumentCount")]
    public class TermAggregatorResponse
    {
        [XmlElement("doc_count_error_upper_bound")]
        [Newtonsoft.Json.JsonProperty("doc_count_error_upper_bound")]
        public int? doc_count_error_upper_bound
        {
            get;
            set;
        }
        [XmlElement("sum_other_doc_count")]
        [Newtonsoft.Json.JsonProperty("sum_other_doc_count")]
        public int? sum_other_doc_count
        {
            get;
            set;
        }
        [XmlElement("buckets")]
        [Newtonsoft.Json.JsonProperty("buckets")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Bucket[] buckets
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
                                           doc_count_error_upper_bound?.ToString() +
                                           sum_other_doc_count?.ToString() +
                                           buckets?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("Statistics")]
    public class Statistics
    {
        [XmlElement("statistics")]
        [Newtonsoft.Json.JsonProperty("statistics")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregatorRoot statistics
        {
            get;
            set;
        }
        [XmlElement("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.ErrorFilterAgg errors
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
                                           statistics?._CalculatedKey?.ToString() +
                                           errors?._CalculatedKey?.ToString();
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
    [XmlRoot("ErrorFilterAgg")]
    public class ErrorFilterAgg
    {
        [XmlElement("filters")]
        [Newtonsoft.Json.JsonProperty("filters")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersAggRoot Filters
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
                                           Filters?._CalculatedKey?.ToString();
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
    [XmlRoot("FiltersAggRoot")]
    public class FiltersAggRoot
    {
        [XmlElement("filters")]
        [Newtonsoft.Json.JsonProperty("filters")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersAgg Filters
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
                                           Filters?._CalculatedKey?.ToString();
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
    [XmlRoot("FiltersAgg")]
    public class FiltersAgg
    {
        [XmlElement("failure")]
        [Newtonsoft.Json.JsonProperty("failure")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeRootAgg Failure
        {
            get;
            set;
        }
        [XmlElement("success")]
        [Newtonsoft.Json.JsonProperty("success")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeRootAgg Success
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
                                           Failure?._CalculatedKey?.ToString() +
                                           Success?._CalculatedKey?.ToString();
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
    [XmlRoot("FiltersRangeRootAgg")]
    public class FiltersRangeRootAgg
    {
        [XmlElement("range")]
        [Newtonsoft.Json.JsonProperty("range")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeAgg Range
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
                                           Range?._CalculatedKey?.ToString();
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
    [XmlRoot("FiltersRangeAgg")]
    public class FiltersRangeAgg
    {
        [XmlElement("StatusCode")]
        [Newtonsoft.Json.JsonProperty("StatusCode")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Timestamp StatusCode
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
                                           StatusCode?._CalculatedKey?.ToString();
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
    [XmlRoot("HitsResponse")]
    public class HitsResponse
    {
        [XmlElement("hits")]
        [Newtonsoft.Json.JsonProperty("hits")]
        public System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.HitRoot> Hits
        {
            get;
            set;
        }
        [XmlElement("total")]
        [Newtonsoft.Json.JsonProperty("total")]
        public int? Total
        {
            get;
            set;
        }
        [XmlElement("max_score")]
        [Newtonsoft.Json.JsonProperty("max_score")]
        public string MaxScore
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
                                           Hits?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           Total?.ToString() +
                                           MaxScore?.ToString();
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
    [XmlRoot("StatsAggregatorResponse")]
    public class StatsAggregatorResponse
    {
        [XmlElement("count")]
        [Newtonsoft.Json.JsonProperty("count")]
        public double? count
        {
            get;
            set;
        }
        [XmlElement("min")]
        [Newtonsoft.Json.JsonProperty("min")]
        public double? min
        {
            get;
            set;
        }
        [XmlElement("max")]
        [Newtonsoft.Json.JsonProperty("max")]
        public double? max
        {
            get;
            set;
        }
        [XmlElement("avg")]
        [Newtonsoft.Json.JsonProperty("avg")]
        public double? avg
        {
            get;
            set;
        }
        [XmlElement("sum")]
        [Newtonsoft.Json.JsonProperty("sum")]
        public double? sum
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
                                           count?.ToString() +
                                           min?.ToString() +
                                           max?.ToString() +
                                           avg?.ToString() +
                                           sum?.ToString();
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
    [XmlRoot("ErrorFilterAggResponse")]
    [Newtonsoft.Json.JsonObject(Title = "ErrorFilterAggResponse")]
    public class ErrorFilterAggResponseBucket
    {
        [XmlElement("failure")]
        [Newtonsoft.Json.JsonProperty("failure")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Bucket Failure
        {
            get;
            set;
        }
        [XmlElement("success")]
        [Newtonsoft.Json.JsonProperty("success")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Bucket Success
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
                                           Failure?._CalculatedKey?.ToString() +
                                           Success?._CalculatedKey?.ToString();
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
    [XmlRoot("ErrorFilterAggResponseBucket")]
    [Newtonsoft.Json.JsonObject(Title = "ErrorFilterAggResponseBucket")]
    public class ErrorFilterAggResponse
    {
        [XmlElement("buckets")]
        [Newtonsoft.Json.JsonProperty("buckets")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.ErrorFilterAggResponseBucket Buckets
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
                                           Buckets?._CalculatedKey?.ToString();
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
    [XmlRoot("Histogram")]
    public class Histogram
    {
        [XmlElement("field")]
        [Newtonsoft.Json.JsonProperty("field")]
        public string Field
        {
            get;
            set;
        }
        [XmlElement("interval")]
        [Newtonsoft.Json.JsonProperty("interval")]
        public string Interval
        {
            get;
            set;
        }
        [XmlElement("format")]
        [Newtonsoft.Json.JsonProperty("format")]
        public string Format
        {
            get;
            set;
        }
        [XmlElement("offset")]
        [Newtonsoft.Json.JsonProperty("offset")]
        public string Offset
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
                                           Field?.ToString() +
                                           Interval?.ToString() +
                                           Format?.ToString() +
                                           Offset?.ToString();
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
    [XmlRoot("HistogramRoot")]
    public class HistogramRoot
    {
        [XmlElement("date_histogram")]
        [Newtonsoft.Json.JsonProperty("date_histogram")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Histogram DateHistogram
        {
            get;
            set;
        }
        [XmlElement("aggs")]
        [Newtonsoft.Json.JsonProperty("aggs")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Statistics Aggregator
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
                                           DateHistogram?._CalculatedKey?.ToString() +
                                           Aggregator?._CalculatedKey?.ToString();
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
    [XmlRoot("BucketHistogram")]
    public class BucketHistogram
    {
        [XmlElement("field")]
        [Newtonsoft.Json.JsonProperty("field")]
        public string Field
        {
            get;
            set;
        }
        [XmlElement("interval")]
        [Newtonsoft.Json.JsonProperty("interval")]
        public int? Interval
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
                                           Field?.ToString() +
                                           Interval?.ToString();
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
    [XmlRoot("BucketHistogramRoot")]
    public class BucketHistogramRoot
    {
        [XmlElement("histogram")]
        [Newtonsoft.Json.JsonProperty("histogram")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.BucketHistogram Histogram
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
                                           Histogram?._CalculatedKey?.ToString();
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
    [XmlRoot("HistogramResponse")]
    public class HistogramResponse
    {
        [XmlElement("buckets")]
        [Newtonsoft.Json.JsonProperty("buckets")]
        public System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.HistogramBucket> Buckets
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
                                           Buckets?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("HistogramBucket")]
    public class HistogramBucket
    {
        [XmlElement("key_as_string")]
        [Newtonsoft.Json.JsonProperty("key_as_string")]
        public string KeyAsString
        {
            get;
            set;
        }
        [XmlElement("Key")]
        [Newtonsoft.Json.JsonProperty("Key")]
        public decimal? Key
        {
            get;
            set;
        }
        [XmlElement("doc_count")]
        [Newtonsoft.Json.JsonProperty("doc_count")]
        public int? DocCount
        {
            get;
            set;
        }
        [XmlElement("statistics")]
        [Newtonsoft.Json.JsonProperty("statistics")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregatorResponse Statistics
        {
            get;
            set;
        }
        [XmlElement("errors")]
        [Newtonsoft.Json.JsonProperty("errors")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.ErrorFilterAggResponse Errors
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
                                           KeyAsString?.ToString() +
                                           Key?.ToString() +
                                           DocCount?.ToString() +
                                           Statistics?._CalculatedKey?.ToString() +
                                           Errors?._CalculatedKey?.ToString();
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
    [XmlRoot("Status")]
    public class Status
    {
        [XmlElement("name")]
        [Newtonsoft.Json.JsonProperty("name")]
        public string name
        {
            get;
            set;
        }
        [XmlElement("cluster_name")]
        [Newtonsoft.Json.JsonProperty("cluster_name")]
        public string cluster_name
        {
            get;
            set;
        }
        [XmlElement("cluster_uuid")]
        [Newtonsoft.Json.JsonProperty("cluster_uuid")]
        public string cluster_uuid
        {
            get;
            set;
        }
        [XmlElement("version")]
        [Newtonsoft.Json.JsonProperty("version")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Version version
        {
            get;
            set;
        }
        [XmlElement("tagline")]
        [Newtonsoft.Json.JsonProperty("tagline")]
        public string tagline
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
                                           name?.ToString() +
                                           cluster_name?.ToString() +
                                           cluster_uuid?.ToString() +
                                           version?._CalculatedKey?.ToString() +
                                           tagline?.ToString();
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
    [XmlRoot("version")]
    [Newtonsoft.Json.JsonObject(Title = "version")]
    public class Version
    {
        [XmlElement("number")]
        [Newtonsoft.Json.JsonProperty("number")]
        public string number
        {
            get;
            set;
        }
        [XmlElement("build_hash")]
        [Newtonsoft.Json.JsonProperty("build_hash")]
        public string build_hash
        {
            get;
            set;
        }
        [XmlElement("build_date")]
        [Newtonsoft.Json.JsonProperty("build_date")]
        public DateTime? build_date
        {
            get;
            set;
        }
        [XmlElement("build_snapshot")]
        [Newtonsoft.Json.JsonProperty("build_snapshot")]
        public bool build_snapshot
        {
            get;
            set;
        }
        [XmlElement("lucene_version")]
        [Newtonsoft.Json.JsonProperty("lucene_version")]
        public string lucene_version
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
                                           number?.ToString() +
                                           build_hash?.ToString() +
                                           build_date?.ToString() +
                                           (build_snapshot == true).ToString() +
                                           lucene_version?.ToString();
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
    [XmlRoot("source")]
    [Newtonsoft.Json.JsonObject(Title = "source")]
    public class Hit
    {
        [XmlElement("RequestPath")]
        [Newtonsoft.Json.JsonProperty("RequestPath")]
        public string RequestPath
        {
            get;
            set;
        }
        [XmlElement("Message")]
        [Newtonsoft.Json.JsonProperty("Message")]
        public string Message
        {
            get;
            set;
        }
        [XmlElement("RequestId")]
        [Newtonsoft.Json.JsonProperty("RequestId")]
        public string RequestId
        {
            get;
            set;
        }
        [XmlElement("RequestMethod")]
        [Newtonsoft.Json.JsonProperty("RequestMethod")]
        public string RequestMethod
        {
            get;
            set;
        }
        [XmlElement("ElapsedMsecs")]
        [Newtonsoft.Json.JsonProperty("ElapsedMsecs")]
        public float? ElapsedMsecs
        {
            get;
            set;
        }
        [XmlElement("IP")]
        [Newtonsoft.Json.JsonProperty("IP")]
        public string IP
        {
            get;
            set;
        }
        [XmlElement("Service")]
        [Newtonsoft.Json.JsonProperty("Service")]
        public string Service
        {
            get;
            set;
        }
        [XmlElement("Operation")]
        [Newtonsoft.Json.JsonProperty("Operation")]
        public string Operation
        {
            get;
            set;
        }
        [XmlElement("StatusCode")]
        [Newtonsoft.Json.JsonProperty("StatusCode")]
        public int? StatusCode
        {
            get;
            set;
        }
        [XmlElement("Timestamp")]
        [Newtonsoft.Json.JsonProperty("Timestamp")]
        public DateTime? Timestamp
        {
            get;
            set;
        }
        [XmlElement("tags")]
        [Newtonsoft.Json.JsonProperty("tags")]
        public string[] tags
        {
            get;
            set;
        }
        [XmlElement("@timestamp")]
        [Newtonsoft.Json.JsonProperty("@timestamp")]
        public DateTime? timestamp
        {
            get;
            set;
        }
        [XmlElement("Username")]
        [Newtonsoft.Json.JsonProperty("Username")]
        public string Username
        {
            get;
            set;
        }
        [XmlElement("@version")]
        [Newtonsoft.Json.JsonProperty("@version")]
        public string version
        {
            get;
            set;
        }
        [XmlElement("RequestUri")]
        [Newtonsoft.Json.JsonProperty("RequestUri")]
        public string RequestUri
        {
            get;
            set;
        }
        [XmlElement("ClientId")]
        [Newtonsoft.Json.JsonProperty("ClientId")]
        public string ClientId
        {
            get;
            set;
        }
        [XmlElement("ClientName")]
        [Newtonsoft.Json.JsonProperty("ClientName")]
        public string ClientName
        {
            get;
            set;
        }
        [XmlElement("Product")]
        [Newtonsoft.Json.JsonProperty("Product")]
        public string Product
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
                                           RequestPath?.ToString() +
                                           Message?.ToString() +
                                           RequestId?.ToString() +
                                           RequestMethod?.ToString() +
                                           ElapsedMsecs?.ToString() +
                                           IP?.ToString() +
                                           Service?.ToString() +
                                           Operation?.ToString() +
                                           StatusCode?.ToString() +
                                           Timestamp?.ToString() +
                                           tags?.ToList()?.Count().ToString() +
                                           timestamp?.ToString() +
                                           Username?.ToString() +
                                           version?.ToString() +
                                           RequestUri?.ToString() +
                                           ClientId?.ToString() +
                                           ClientName?.ToString() +
                                           Product?.ToString();
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
    [XmlRoot("HitRoot")]
    public class HitRoot
    {
        [XmlElement("_source")]
        [Newtonsoft.Json.JsonProperty("_source")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Hit Source
        {
            get;
            set;
        }
        [XmlElement("_id")]
        [Newtonsoft.Json.JsonProperty("_id")]
        public string ID
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
                                           Source?._CalculatedKey?.ToString() +
                                           ID?.ToString();
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
    [XmlRoot("source")]
    [Newtonsoft.Json.JsonObject(Title = "source")]
    public class Meta
    {
        [XmlElement("excludes")]
        [Newtonsoft.Json.JsonProperty("excludes")]
        public string[] excludes
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
                                           excludes?.ToList()?.Count().ToString();
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
    [XmlRoot("Sort")]
    public class Sort
    {
        [XmlElement("Timestamp")]
        [Newtonsoft.Json.JsonProperty("Timestamp")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Order Timestamp
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
                                           Timestamp?._CalculatedKey?.ToString();
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
    [XmlRoot("QueryString")]
    public class QueryString
    {
        [XmlElement("analyze_wildcard")]
        [Newtonsoft.Json.JsonProperty("analyze_wildcard")]
        public bool AnalyzeWildcard
        {
            get;
            set;
        }
        [XmlElement("query")]
        [Newtonsoft.Json.JsonProperty("query")]
        public string Query
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
                                           (AnalyzeWildcard == true).ToString() +
                                           Query?.ToString();
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
    public class Query
    {
        [XmlElement("bool")]
        [Newtonsoft.Json.JsonProperty("bool")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Logic logic
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
                                           logic?._CalculatedKey?.ToString();
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
    public class Logic
    {
        [XmlElement("must")]
        [Newtonsoft.Json.JsonProperty("must")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Must must
        {
            get;
            set;
        }
        [XmlElement("filter")]
        [Newtonsoft.Json.JsonProperty("filter")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Filter filter
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
    public class Must
    {
        [XmlElement("match_all")]
        [Newtonsoft.Json.JsonProperty("match_all")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.MatchAll match_all
        {
            get;
            set;
        }
        [XmlElement("query_string")]
        [Newtonsoft.Json.JsonProperty("query_string")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.QueryString QueryString
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
                                           match_all?._CalculatedKey?.ToString() +
                                           QueryString?._CalculatedKey?.ToString();
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
    [XmlRoot("match_all")]
    [Newtonsoft.Json.JsonObject(Title = "match_all")]
    public class MatchAll
    {
        [XmlElement("_CalculatedKey")]
        [Newtonsoft.Json.JsonProperty("_CalculatedKey")]
        public int? _CalculatedKey
        {
            get
            {
                try
                {
                    var allPropsConcated = "_CalculatedKey-";
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
        [XmlElement("@timestamp")]
        [Newtonsoft.Json.JsonProperty("@timestamp")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Timestamp timestamp
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
        [XmlElement("gt")]
        [Newtonsoft.Json.JsonProperty("gt")]
        public string gt
        {
            get;
            set;
        }
        [XmlElement("lt")]
        [Newtonsoft.Json.JsonProperty("lt")]
        public string lt
        {
            get;
            set;
        }
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
                                           gt?.ToString() +
                                           lt?.ToString() +
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
    [XmlRoot("filter")]
    [Newtonsoft.Json.JsonObject(Title = "filter")]
    public class Filter
    {
        [XmlElement("range")]
        [Newtonsoft.Json.JsonProperty("range")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Range range
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
    [XmlRoot("buckets")]
    [Newtonsoft.Json.JsonObject(Title = "buckets")]
    public class Bucket
    {
        [XmlElement("key")]
        [Newtonsoft.Json.JsonProperty("key")]
        public string key
        {
            get;
            set;
        }
        [XmlElement("doc_count")]
        [Newtonsoft.Json.JsonProperty("doc_count")]
        public int? doc_count
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
                                           doc_count?.ToString();
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
    [XmlRoot("Order")]
    public class Order
    {
        [XmlElement("order")]
        [Newtonsoft.Json.JsonProperty("order")]
        public string order
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
                                           order?.ToString();
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
