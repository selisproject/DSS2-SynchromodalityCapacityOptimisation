
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;

using DSS2_SynchromodalityCapacityOptimisation.DAL;

namespace DSS2_SynchromodalityCapacityOptimisation.BO
{
	/// <summary>
	/// The MakeRequest extensions
	/// </summary>
	public static class MakeRequestExtensions
	{
        public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.SearchRequest Query(string q, string fromDate, string toDate){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Query")) {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.SearchRequest searchObject = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.SearchRequest();
System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Sort> sorts = new System.Collections.Generic.List<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Sort>();
sorts.Add(DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.SortByTimestamp("desc"));
searchObject.sort = sorts.ToList();searchObject.query = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetQuery(q, fromDate, toDate);DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Meta meta = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Meta();
meta.excludes = new string[] { "message" };searchObject.source = meta;return searchObject;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.AnalyticsRequest Analytics(string q, string fromDate, string toDate){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "Analytics")) {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.AnalyticsRequest analyticsObject = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.AnalyticsRequest();
analyticsObject.query = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetQuery(q, fromDate, toDate);string interval = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetInterval(fromDate);
analyticsObject.aggs = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetAggregations(interval);DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Meta meta = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Meta();
meta.excludes = new string[] { "message" };analyticsObject.source = meta;return analyticsObject;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot GetTermQuery(string field, int? size, bool aggsEnable){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetTermQuery")) {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot q = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregator term = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregator();
q.terms = term;term.field = field;if ((aggsEnable)) {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermsAggregationRequest aggs = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermsAggregationRequest();
q.Aggs = aggs;q.Aggs.ResposeStatus = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetErrorFilter();q.Aggs.ResponseTime = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetStatQuery("ElapsedMsecs");}
if ((size > 0)) {
term.size = size;}
return q;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregatorRoot GetStatQuery(string field){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetStatQuery")) {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregatorRoot q = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregatorRoot();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregator stats = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregator();
q.stats = stats;stats.field = field;return q;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Must GetQueryStringQuery(string q){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetQueryStringQuery")) {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Must must = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Must();
if (((q == null || q == ""))) {
zAppDev.DotNet.Framework.Utilities.Serializer<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.MatchAll> serializer = new zAppDev.DotNet.Framework.Utilities.Serializer<DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.MatchAll>();
must.match_all = serializer.FromJson("{\"must\": {\"match_all\": {}}");}
else {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.QueryString queryString = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.QueryString();
queryString.AnalyzeWildcard = true;queryString.Query = q;must.QueryString = queryString;}
return must;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.HistogramRoot GetHistogramQuery(string field, string interval){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetHistogramQuery")) {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.HistogramRoot q = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.HistogramRoot();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Histogram hist = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Histogram();
q.DateHistogram = hist;hist.Field = field;hist.Interval = interval;hist.Format = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetDateFormat(interval);hist.Offset = "+0h";DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Statistics stats = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Statistics();
stats.statistics = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetStatQuery("ElapsedMsecs");stats.errors = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetErrorFilter();q.Aggregator = stats;return q;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.BucketHistogramRoot GetBucketHistogramQuery(string field, int? interval){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetBucketHistogramQuery")) {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.BucketHistogramRoot q = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.BucketHistogramRoot();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.BucketHistogram hist = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.BucketHistogram();
q.Histogram = hist;hist.Field = field;hist.Interval = interval;return q;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Range GetFilterByTimePeriod(string fromDate, string toDate){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetFilterByTimePeriod")) {
if (((fromDate == null || fromDate == ""))) {
fromDate = "now-1w";}
if (((toDate == null || toDate == ""))) {
toDate = "now";}
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Range timeRange = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Range();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Timestamp timestamp = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Timestamp();
timestamp.gte = fromDate;timestamp.lte = toDate;timeRange.timestamp = timestamp;return timeRange;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Sort SortByTimestamp(string direction){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "SortByTimestamp")) {
if (((direction == null || direction == ""))) {
direction = "desc";}
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Sort sortObject = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Sort();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Order orderObject = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Order();
orderObject.order = direction;sortObject.Timestamp = orderObject;return sortObject;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Query GetQuery(string q, string fromDate, string toDate){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetQuery")) {
if (((fromDate == null || fromDate == ""))) {
fromDate = "now-1w";}
if (((toDate == null || toDate == ""))) {
toDate = "now";}
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Query queryObject = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Query();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Logic logic = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Logic();
logic.must = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetQueryStringQuery(q);DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Filter filter = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Filter();
filter.range = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetFilterByTimePeriod(fromDate, toDate);logic.filter = filter;queryObject.logic = logic;return queryObject;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.OBAggregatorRequest GetAggregations(string interval){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetAggregations")) {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.OBAggregatorRequest aggs = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.OBAggregatorRequest();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot top_service = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetTermQuery("Service.keyword", 5, true);
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot top_operation = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetTermQuery("Operation.keyword", 5, true);
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot from_ip = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetTermQuery("IP.keyword", 5, true);
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot verb_type = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetTermQuery("RequestMethod.keyword", 5, true);
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.TermAggregatorRoot status = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetTermQuery("StatusCode", 5, true);
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.StatsAggregatorRoot elapsed_msecs = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetStatQuery("ElapsedMsecs");
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.HistogramRoot req_over_time = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetHistogramQuery("Timestamp", interval);
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.BucketHistogramRoot req_latency = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetBucketHistogramQuery("ElapsedMsecs", 2000);
aggs.TopService = top_service;aggs.TopOperation = top_operation;aggs.FromIP = from_ip;aggs.VerbType = verb_type;aggs.Status = status;aggs.ElapsedMsecs = elapsed_msecs;aggs.RequestOverTime = req_over_time;aggs.RequestLatency = req_latency;aggs.Errors = DSS2_SynchromodalityCapacityOptimisation.BO.MakeRequestExtensions.GetErrorFilter();return aggs;
}
}


public static DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.ErrorFilterAgg GetErrorFilter(){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetErrorFilter")) {
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.ErrorFilterAgg errorFilter = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.ErrorFilterAgg();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersAggRoot filterRoot = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersAggRoot();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersAgg filter = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersAgg();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeRootAgg failureRoot = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeRootAgg();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeRootAgg successRoot = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeRootAgg();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeAgg failure = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeAgg();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeAgg success = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.FiltersRangeAgg();
DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Timestamp timestampFailure = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Timestamp();
timestampFailure.gte = "400";failure.StatusCode = timestampFailure;failureRoot.Range = failure;filter.Failure = failureRoot;DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Timestamp timestampSuccess = new DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Elasticsearch.Timestamp();
timestampSuccess.lt = "400";success.StatusCode = timestampSuccess;successRoot.Range = success;filter.Success = successRoot;filterRoot.Filters = filter;errorFilter.Filters = filterRoot;return errorFilter;
}
}


public static string GetInterval(string fromDate){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetInterval")) {
if ((fromDate == "now-1y")) {
return "month";
}
else if ((fromDate == "now-1M")) {
return "day";
}
else if ((fromDate == "now-1w")) {
return "6h";
}
else if ((fromDate == "now-1d")) {
return "hour";
}
else {
return "day";
}
}
}


public static string GetDateFormat(string interval){using (new zAppDev.DotNet.Framework.Profiling.Profiler("MakeRequest", zAppDev.DotNet.Framework.Profiling.AppDevSymbolType.ClassOperation, "GetDateFormat")) {
if ((interval == "month")) {
return "yyyy-MM";
}
else if ((interval == "day")) {
return "yyyy-MM-dd";
}
else if ((interval == "6h")) {
return "yyyy-MM-dd HH:mm";
}
else if ((interval == "h")) {
return "yyyy-MM-dd HH:mm";
}
else {
return "yyyy-MM-dd HH:mm";
}
}
}



        
	}
}
