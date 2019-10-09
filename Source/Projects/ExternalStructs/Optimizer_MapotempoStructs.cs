using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo
{
    [XmlRoot("Optimizer_MapotempoRoot")]
    public class Optimizer_MapotempoRoot
    {
        [XmlElement("solutions")]
        [Newtonsoft.Json.JsonProperty("solutions")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.solutions[] solutions
        {
            get;
            set;
        }
        [XmlElement("job")]
        [Newtonsoft.Json.JsonProperty("job")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.job job
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
                                           solutions?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           job?._CalculatedKey?.ToString();
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
    [XmlRoot("solutions")]
    public class solutions
    {
        [XmlElement("cost")]
        [Newtonsoft.Json.JsonProperty("cost")]
        public float? cost
        {
            get;
            set;
        }
        [XmlElement("total_distance")]
        [Newtonsoft.Json.JsonProperty("total_distance")]
        public float? total_distance
        {
            get;
            set;
        }
        [XmlElement("total_time")]
        [Newtonsoft.Json.JsonProperty("total_time")]
        public int? total_time
        {
            get;
            set;
        }
        [XmlElement("start_time")]
        [Newtonsoft.Json.JsonProperty("start_time")]
        public int? start_time
        {
            get;
            set;
        }
        [XmlElement("end_time")]
        [Newtonsoft.Json.JsonProperty("end_time")]
        public int? end_time
        {
            get;
            set;
        }
        [XmlElement("routes")]
        [Newtonsoft.Json.JsonProperty("routes")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.routes[] routes
        {
            get;
            set;
        }
        [XmlElement("unassigned")]
        [Newtonsoft.Json.JsonProperty("unassigned")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.activities[] unassigned
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
                                           cost?.ToString() +
                                           total_distance?.ToString() +
                                           total_time?.ToString() +
                                           start_time?.ToString() +
                                           end_time?.ToString() +
                                           routes?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           unassigned?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("routes")]
    public class routes
    {
        [XmlElement("vehicle_id")]
        [Newtonsoft.Json.JsonProperty("vehicle_id")]
        public string vehicle_id
        {
            get;
            set;
        }
        [XmlElement("activities")]
        [Newtonsoft.Json.JsonProperty("activities")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.activities[] activities
        {
            get;
            set;
        }
        [XmlElement("total_distance")]
        [Newtonsoft.Json.JsonProperty("total_distance")]
        public float? total_distance
        {
            get;
            set;
        }
        [XmlElement("total_travel_time")]
        [Newtonsoft.Json.JsonProperty("total_travel_time")]
        public int? total_travel_time
        {
            get;
            set;
        }
        [XmlElement("start_time")]
        [Newtonsoft.Json.JsonProperty("start_time")]
        public int? start_time
        {
            get;
            set;
        }
        [XmlElement("end_time")]
        [Newtonsoft.Json.JsonProperty("end_time")]
        public int? end_time
        {
            get;
            set;
        }
        [XmlElement("geometry")]
        [Newtonsoft.Json.JsonProperty("geometry")]
        public string geometry
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
                                           vehicle_id?.ToString() +
                                           activities?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           total_distance?.ToString() +
                                           total_travel_time?.ToString() +
                                           start_time?.ToString() +
                                           end_time?.ToString() +
                                           geometry?.ToString();
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
    [XmlRoot("activities")]
    public class activities
    {
        [XmlElement("point_id")]
        [Newtonsoft.Json.JsonProperty("point_id")]
        public string point_id
        {
            get;
            set;
        }
        [XmlElement("travel_distance")]
        [Newtonsoft.Json.JsonProperty("travel_distance")]
        public float? travel_distance
        {
            get;
            set;
        }
        [XmlElement("travel_time")]
        [Newtonsoft.Json.JsonProperty("travel_time")]
        public int? travel_time
        {
            get;
            set;
        }
        [XmlElement("waiting_duration")]
        [Newtonsoft.Json.JsonProperty("waiting_duration")]
        public int? waiting_duration
        {
            get;
            set;
        }
        [XmlElement("departure_time")]
        [Newtonsoft.Json.JsonProperty("departure_time")]
        public int? departure_time
        {
            get;
            set;
        }
        [XmlElement("begin_time")]
        [Newtonsoft.Json.JsonProperty("begin_time")]
        public int? begin_time
        {
            get;
            set;
        }
        [XmlElement("service_id")]
        [Newtonsoft.Json.JsonProperty("service_id")]
        public string service_id
        {
            get;
            set;
        }
        [XmlElement("pickup_shipment_id")]
        [Newtonsoft.Json.JsonProperty("pickup_shipment_id")]
        public string pickup_shipment_id
        {
            get;
            set;
        }
        [XmlElement("delivery_shipment_id")]
        [Newtonsoft.Json.JsonProperty("delivery_shipment_id")]
        public string delivery_shipment_id
        {
            get;
            set;
        }
        [XmlElement("detail")]
        [Newtonsoft.Json.JsonProperty("detail")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.detail detail
        {
            get;
            set;
        }
        [XmlElement("shipment_id")]
        [Newtonsoft.Json.JsonProperty("shipment_id")]
        public string shipment_id
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
                                           point_id?.ToString() +
                                           travel_distance?.ToString() +
                                           travel_time?.ToString() +
                                           waiting_duration?.ToString() +
                                           departure_time?.ToString() +
                                           begin_time?.ToString() +
                                           service_id?.ToString() +
                                           pickup_shipment_id?.ToString() +
                                           delivery_shipment_id?.ToString() +
                                           detail?._CalculatedKey?.ToString() +
                                           shipment_id?.ToString();
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
    [XmlRoot("job")]
    public class job
    {
        [XmlElement("id")]
        [Newtonsoft.Json.JsonProperty("id")]
        public string id
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
        [XmlElement("avancement")]
        [Newtonsoft.Json.JsonProperty("avancement")]
        public string avancement
        {
            get;
            set;
        }
        [XmlElement("graph")]
        [Newtonsoft.Json.JsonProperty("graph")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.graph[] graph
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
                                           id?.ToString() +
                                           status?.ToString() +
                                           avancement?.ToString() +
                                           graph?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("graph")]
    public class graph
    {
        [XmlElement("iteration")]
        [Newtonsoft.Json.JsonProperty("iteration")]
        public int? iteration
        {
            get;
            set;
        }
        [XmlElement("time")]
        [Newtonsoft.Json.JsonProperty("time")]
        public float? time
        {
            get;
            set;
        }
        [XmlElement("cost")]
        [Newtonsoft.Json.JsonProperty("cost")]
        public float? cost
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
                                           iteration?.ToString() +
                                           time?.ToString() +
                                           cost?.ToString();
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
    [XmlRoot("Optimizer_MapotempoRoot1")]
    [Newtonsoft.Json.JsonObject(Title = "Optimizer_MapotempoRoot1")]
    public class VrpProblem
    {
        [XmlElement("vrp")]
        [Newtonsoft.Json.JsonProperty("vrp")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.vrp vrp
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
                                           vrp?._CalculatedKey?.ToString();
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
    [XmlRoot("vrp")]
    public class vrp
    {
        [XmlElement("points")]
        [Newtonsoft.Json.JsonProperty("points")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.points[] points
        {
            get;
            set;
        }
        [XmlElement("vehicles")]
        [Newtonsoft.Json.JsonProperty("vehicles")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.vehicles[] vehicles
        {
            get;
            set;
        }
        [XmlElement("services")]
        [Newtonsoft.Json.JsonProperty("services")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.services[] services
        {
            get;
            set;
        }
        [XmlElement("configuration")]
        [Newtonsoft.Json.JsonProperty("configuration")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.configuration configuration
        {
            get;
            set;
        }
        [XmlElement("rests")]
        [Newtonsoft.Json.JsonProperty("rests")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.rests[] rests
        {
            get;
            set;
        }
        [XmlElement("shipments")]
        [Newtonsoft.Json.JsonProperty("shipments")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.shipments[] shipments
        {
            get;
            set;
        }
        [XmlElement("units")]
        [Newtonsoft.Json.JsonProperty("units")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.units[] units
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
                                           points?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           vehicles?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           services?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           configuration?._CalculatedKey?.ToString() +
                                           rests?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           shipments?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           units?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("points")]
    public class points
    {
        [XmlElement("id")]
        [Newtonsoft.Json.JsonProperty("id")]
        public string id
        {
            get;
            set;
        }
        [XmlElement("location")]
        [Newtonsoft.Json.JsonProperty("location")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.location location
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
                                           id?.ToString() +
                                           location?._CalculatedKey?.ToString();
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
        public float? lat
        {
            get;
            set;
        }
        [XmlElement("lon")]
        [Newtonsoft.Json.JsonProperty("lon")]
        public float? lon
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
                                           lon?.ToString();
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
    [XmlRoot("vehicles")]
    public class vehicles
    {
        [XmlElement("id")]
        [Newtonsoft.Json.JsonProperty("id")]
        public string id
        {
            get;
            set;
        }
        [XmlElement("router_mode")]
        [Newtonsoft.Json.JsonProperty("router_mode")]
        public string router_mode
        {
            get;
            set;
        }
        [XmlElement("router_dimension")]
        [Newtonsoft.Json.JsonProperty("router_dimension")]
        public string router_dimension
        {
            get;
            set;
        }
        [XmlElement("speed_multiplier")]
        [Newtonsoft.Json.JsonProperty("speed_multiplier")]
        public int? speed_multiplier
        {
            get;
            set;
        }
        [XmlElement("timewindow")]
        [Newtonsoft.Json.JsonProperty("timewindow")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.timewindow timewindow
        {
            get;
            set;
        }
        [XmlElement("start_point_id")]
        [Newtonsoft.Json.JsonProperty("start_point_id")]
        public string start_point_id
        {
            get;
            set;
        }
        [XmlElement("end_point_id")]
        [Newtonsoft.Json.JsonProperty("end_point_id")]
        public string end_point_id
        {
            get;
            set;
        }
        [XmlElement("cost_fixed")]
        [Newtonsoft.Json.JsonProperty("cost_fixed")]
        public int? cost_fixed
        {
            get;
            set;
        }
        [XmlElement("cost_distance_multiplier")]
        [Newtonsoft.Json.JsonProperty("cost_distance_multiplier")]
        public float? cost_distance_multiplier
        {
            get;
            set;
        }
        [XmlElement("cost_time_multiplier")]
        [Newtonsoft.Json.JsonProperty("cost_time_multiplier")]
        public int? cost_time_multiplier
        {
            get;
            set;
        }
        [XmlElement("cost_waiting_time_multiplier")]
        [Newtonsoft.Json.JsonProperty("cost_waiting_time_multiplier")]
        public int? cost_waiting_time_multiplier
        {
            get;
            set;
        }
        [XmlElement("cost_late_multiplier")]
        [Newtonsoft.Json.JsonProperty("cost_late_multiplier")]
        public int? cost_late_multiplier
        {
            get;
            set;
        }
        [XmlElement("rest_ids")]
        [Newtonsoft.Json.JsonProperty("rest_ids")]
        public string[] rest_ids
        {
            get;
            set;
        }
        [XmlElement("capacities")]
        [Newtonsoft.Json.JsonProperty("capacities")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.capacity[] capacities
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
                                           id?.ToString() +
                                           router_mode?.ToString() +
                                           router_dimension?.ToString() +
                                           speed_multiplier?.ToString() +
                                           timewindow?._CalculatedKey?.ToString() +
                                           start_point_id?.ToString() +
                                           end_point_id?.ToString() +
                                           cost_fixed?.ToString() +
                                           cost_distance_multiplier?.ToString() +
                                           cost_time_multiplier?.ToString() +
                                           cost_waiting_time_multiplier?.ToString() +
                                           cost_late_multiplier?.ToString() +
                                           rest_ids?.ToList()?.Count().ToString() +
                                           capacities?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("timewindow")]
    public class timewindow
    {
        [XmlElement("start")]
        [Newtonsoft.Json.JsonProperty("start")]
        public int? start
        {
            get;
            set;
        }
        [XmlElement("end")]
        [Newtonsoft.Json.JsonProperty("end")]
        public int? end
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
                                           start?.ToString() +
                                           end?.ToString();
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
    [XmlRoot("services")]
    public class services
    {
        [XmlElement("id")]
        [Newtonsoft.Json.JsonProperty("id")]
        public string id
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
        [XmlElement("activity")]
        [Newtonsoft.Json.JsonProperty("activity")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.activity activity
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
                                           id?.ToString() +
                                           type?.ToString() +
                                           activity?._CalculatedKey?.ToString();
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
    [XmlRoot("activity")]
    public class activity
    {
        [XmlElement("point_id")]
        [Newtonsoft.Json.JsonProperty("point_id")]
        public string point_id
        {
            get;
            set;
        }
        [XmlElement("timewindows")]
        [Newtonsoft.Json.JsonProperty("timewindows")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.timewindows[] timewindows
        {
            get;
            set;
        }
        [XmlElement("duration")]
        [Newtonsoft.Json.JsonProperty("duration")]
        public int? duration
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
                                           point_id?.ToString() +
                                           timewindows?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           duration?.ToString();
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
    [XmlRoot("timewindows")]
    public class timewindows
    {
        [XmlElement("start")]
        [Newtonsoft.Json.JsonProperty("start")]
        public int? start
        {
            get;
            set;
        }
        [XmlElement("end")]
        [Newtonsoft.Json.JsonProperty("end")]
        public int? end
        {
            get;
            set;
        }
        [XmlElement("day_index")]
        [Newtonsoft.Json.JsonProperty("day_index")]
        public int? day_index
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
                                           start?.ToString() +
                                           end?.ToString() +
                                           day_index?.ToString();
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
    [XmlRoot("configuration")]
    public class configuration
    {
        [XmlElement("preprocessing")]
        [Newtonsoft.Json.JsonProperty("preprocessing")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.preprocessing preprocessing
        {
            get;
            set;
        }
        [XmlElement("resolution")]
        [Newtonsoft.Json.JsonProperty("resolution")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.resolution resolution
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
                                           preprocessing?._CalculatedKey?.ToString() +
                                           resolution?._CalculatedKey?.ToString();
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
    [XmlRoot("preprocessing")]
    public class preprocessing
    {
        [XmlElement("prefer_short_segment")]
        [Newtonsoft.Json.JsonProperty("prefer_short_segment")]
        public bool prefer_short_segment
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
                                           (prefer_short_segment == true).ToString();
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
    [XmlRoot("resolution")]
    public class resolution
    {
        [XmlElement("duration")]
        [Newtonsoft.Json.JsonProperty("duration")]
        public int? duration
        {
            get;
            set;
        }
        [XmlElement("iterations_without_improvment")]
        [Newtonsoft.Json.JsonProperty("iterations_without_improvment")]
        public int? iterations_without_improvment
        {
            get;
            set;
        }
        [XmlElement("initial_time_out")]
        [Newtonsoft.Json.JsonProperty("initial_time_out")]
        public int? initial_time_out
        {
            get;
            set;
        }
        [XmlElement("time_out_multiplier")]
        [Newtonsoft.Json.JsonProperty("time_out_multiplier")]
        public int? time_out_multiplier
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
                                           duration?.ToString() +
                                           iterations_without_improvment?.ToString() +
                                           initial_time_out?.ToString() +
                                           time_out_multiplier?.ToString();
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
    [XmlRoot("rests")]
    public class rests
    {
        [XmlElement("id")]
        [Newtonsoft.Json.JsonProperty("id")]
        public string id
        {
            get;
            set;
        }
        [XmlElement("timewindows")]
        [Newtonsoft.Json.JsonProperty("timewindows")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.restsTimewindows[] timewindows
        {
            get;
            set;
        }
        [XmlElement("duration")]
        [Newtonsoft.Json.JsonProperty("duration")]
        public int? duration
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
                                           id?.ToString() +
                                           timewindows?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           duration?.ToString();
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
    [XmlRoot("restsTimewindows")]
    public class restsTimewindows
    {
        [XmlElement("start")]
        [Newtonsoft.Json.JsonProperty("start")]
        public int? start
        {
            get;
            set;
        }
        [XmlElement("end")]
        [Newtonsoft.Json.JsonProperty("end")]
        public int? end
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
                                           start?.ToString() +
                                           end?.ToString();
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
    [XmlRoot("Optimizer_MapotempoRoot1")]
    public class Optimizer_MapotempoRoot1
    {
        [XmlElement("shipments")]
        [Newtonsoft.Json.JsonProperty("shipments")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.shipments shipments
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
                                           shipments?._CalculatedKey?.ToString();
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
    [XmlRoot("shipments")]
    public class shipments
    {
        [XmlElement("id")]
        [Newtonsoft.Json.JsonProperty("id")]
        public string id
        {
            get;
            set;
        }
        [XmlElement("priority")]
        [Newtonsoft.Json.JsonProperty("priority")]
        public int? priority
        {
            get;
            set;
        }
        [XmlElement("sticky_vehicle_ids")]
        [Newtonsoft.Json.JsonProperty("sticky_vehicle_ids")]
        public string sticky_vehicle_ids
        {
            get;
            set;
        }
        [XmlElement("skills")]
        [Newtonsoft.Json.JsonProperty("skills")]
        public string skills
        {
            get;
            set;
        }
        [XmlElement("pickup")]
        [Newtonsoft.Json.JsonProperty("pickup")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.pickup pickup
        {
            get;
            set;
        }
        [XmlElement("delivery")]
        [Newtonsoft.Json.JsonProperty("delivery")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.delivery delivery
        {
            get;
            set;
        }
        [XmlElement("quantities")]
        [Newtonsoft.Json.JsonProperty("quantities")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.quantities[] quantities
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
                                           id?.ToString() +
                                           priority?.ToString() +
                                           sticky_vehicle_ids?.ToString() +
                                           skills?.ToString() +
                                           pickup?._CalculatedKey?.ToString() +
                                           delivery?._CalculatedKey?.ToString() +
                                           quantities?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("pickup")]
    public class pickup
    {
        [XmlElement("duration")]
        [Newtonsoft.Json.JsonProperty("duration")]
        public int? duration
        {
            get;
            set;
        }
        [XmlElement("additional_value")]
        [Newtonsoft.Json.JsonProperty("additional_value")]
        public int? additional_value
        {
            get;
            set;
        }
        [XmlElement("setup_duration")]
        [Newtonsoft.Json.JsonProperty("setup_duration")]
        public int? setup_duration
        {
            get;
            set;
        }
        [XmlElement("late_multiplier")]
        [Newtonsoft.Json.JsonProperty("late_multiplier")]
        public int? late_multiplier
        {
            get;
            set;
        }
        [XmlElement("timewindow_start_day_shift_number")]
        [Newtonsoft.Json.JsonProperty("timewindow_start_day_shift_number")]
        public int? timewindow_start_day_shift_number
        {
            get;
            set;
        }
        [XmlElement("point_id")]
        [Newtonsoft.Json.JsonProperty("point_id")]
        public string point_id
        {
            get;
            set;
        }
        [XmlElement("value_matrix_index")]
        [Newtonsoft.Json.JsonProperty("value_matrix_index")]
        public int? value_matrix_index
        {
            get;
            set;
        }
        [XmlElement("timewindows")]
        [Newtonsoft.Json.JsonProperty("timewindows")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.timewindows[] timewindows
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
                                           duration?.ToString() +
                                           additional_value?.ToString() +
                                           setup_duration?.ToString() +
                                           late_multiplier?.ToString() +
                                           timewindow_start_day_shift_number?.ToString() +
                                           point_id?.ToString() +
                                           value_matrix_index?.ToString() +
                                           timewindows?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("delivery")]
    public class delivery
    {
        [XmlElement("duration")]
        [Newtonsoft.Json.JsonProperty("duration")]
        public int? duration
        {
            get;
            set;
        }
        [XmlElement("additional_value")]
        [Newtonsoft.Json.JsonProperty("additional_value")]
        public int? additional_value
        {
            get;
            set;
        }
        [XmlElement("setup_duration")]
        [Newtonsoft.Json.JsonProperty("setup_duration")]
        public int? setup_duration
        {
            get;
            set;
        }
        [XmlElement("late_multiplier")]
        [Newtonsoft.Json.JsonProperty("late_multiplier")]
        public int? late_multiplier
        {
            get;
            set;
        }
        [XmlElement("timewindow_start_day_shift_number")]
        [Newtonsoft.Json.JsonProperty("timewindow_start_day_shift_number")]
        public int? timewindow_start_day_shift_number
        {
            get;
            set;
        }
        [XmlElement("point_id")]
        [Newtonsoft.Json.JsonProperty("point_id")]
        public string point_id
        {
            get;
            set;
        }
        [XmlElement("value_matrix_index")]
        [Newtonsoft.Json.JsonProperty("value_matrix_index")]
        public int? value_matrix_index
        {
            get;
            set;
        }
        [XmlElement("timewindows")]
        [Newtonsoft.Json.JsonProperty("timewindows")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.deliveryTimewindows[] timewindows
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
                                           duration?.ToString() +
                                           additional_value?.ToString() +
                                           setup_duration?.ToString() +
                                           late_multiplier?.ToString() +
                                           timewindow_start_day_shift_number?.ToString() +
                                           point_id?.ToString() +
                                           value_matrix_index?.ToString() +
                                           timewindows?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("deliveryTimewindows")]
    public class deliveryTimewindows
    {
        [XmlElement("start")]
        [Newtonsoft.Json.JsonProperty("start")]
        public int? start
        {
            get;
            set;
        }
        [XmlElement("end")]
        [Newtonsoft.Json.JsonProperty("end")]
        public int? end
        {
            get;
            set;
        }
        [XmlElement("day_index")]
        [Newtonsoft.Json.JsonProperty("day_index")]
        public int? day_index
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
                                           start?.ToString() +
                                           end?.ToString() +
                                           day_index?.ToString();
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
    [XmlRoot("quantities")]
    public class quantities
    {
        [XmlElement("unit_id")]
        [Newtonsoft.Json.JsonProperty("unit_id")]
        public string unit_id
        {
            get;
            set;
        }
        [XmlElement("value")]
        [Newtonsoft.Json.JsonProperty("value")]
        public float? value
        {
            get;
            set;
        }
        [XmlElement("unit")]
        [Newtonsoft.Json.JsonProperty("unit")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.unit unit
        {
            get;
            set;
        }
        [XmlElement("current_load")]
        [Newtonsoft.Json.JsonProperty("current_load")]
        public decimal? current_load
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
                                           unit_id?.ToString() +
                                           value?.ToString() +
                                           unit?._CalculatedKey?.ToString() +
                                           current_load?.ToString();
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
    [XmlRoot("capacity")]
    public class capacity
    {
        [XmlElement("unit_id")]
        [Newtonsoft.Json.JsonProperty("unit_id")]
        public string unit_id
        {
            get;
            set;
        }
        [XmlElement("limit")]
        [Newtonsoft.Json.JsonProperty("limit")]
        public int? limit
        {
            get;
            set;
        }
        [XmlElement("overload_multiplier")]
        [Newtonsoft.Json.JsonProperty("overload_multiplier")]
        public int? overload_multiplier
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
                                           unit_id?.ToString() +
                                           limit?.ToString() +
                                           overload_multiplier?.ToString();
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
    [XmlRoot("units")]
    public class units
    {
        [XmlElement("id")]
        [Newtonsoft.Json.JsonProperty("id")]
        public string id
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
        [XmlElement("counting")]
        [Newtonsoft.Json.JsonProperty("counting")]
        public bool counting
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
                                           id?.ToString() +
                                           label?.ToString() +
                                           (counting == true).ToString();
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
    [XmlRoot("Optimizer_MapotempoRoot2")]
    public class Optimizer_MapotempoRoot2
    {
        [XmlElement("detail")]
        [Newtonsoft.Json.JsonProperty("detail")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.detail detail
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
                                           detail?._CalculatedKey?.ToString();
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
    [XmlRoot("detail")]
    public class detail
    {
        [XmlElement("lat")]
        [Newtonsoft.Json.JsonProperty("lat")]
        public float? lat
        {
            get;
            set;
        }
        [XmlElement("lon")]
        [Newtonsoft.Json.JsonProperty("lon")]
        public float? lon
        {
            get;
            set;
        }
        [XmlElement("skills")]
        [Newtonsoft.Json.JsonProperty("skills")]
        public System.Object[] skills
        {
            get;
            set;
        }
        [XmlElement("setup_duration")]
        [Newtonsoft.Json.JsonProperty("setup_duration")]
        public int? setup_duration
        {
            get;
            set;
        }
        [XmlElement("duration")]
        [Newtonsoft.Json.JsonProperty("duration")]
        public int? duration
        {
            get;
            set;
        }
        [XmlElement("additional_value")]
        [Newtonsoft.Json.JsonProperty("additional_value")]
        public int? additional_value
        {
            get;
            set;
        }
        [XmlElement("timewindows")]
        [Newtonsoft.Json.JsonProperty("timewindows")]
        public System.Object[] timewindows
        {
            get;
            set;
        }
        [XmlElement("quantities")]
        [Newtonsoft.Json.JsonProperty("quantities")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.quantities[] quantities
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
                                           lon?.ToString() +
                                           skills?.ToList()?.Count().ToString() +
                                           setup_duration?.ToString() +
                                           duration?.ToString() +
                                           additional_value?.ToString() +
                                           timewindows?.ToList()?.Count().ToString() +
                                           quantities?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("unit")]
    public class unit
    {
        [XmlElement("attributes")]
        [Newtonsoft.Json.JsonProperty("attributes")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.Optimizer_Mapotempo.attributes attributes
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
                                           attributes?._CalculatedKey?.ToString();
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
    [XmlRoot("attributes")]
    public class attributes
    {
        [XmlElement("id")]
        [Newtonsoft.Json.JsonProperty("id")]
        public string id
        {
            get;
            set;
        }
        [XmlElement("counting")]
        [Newtonsoft.Json.JsonProperty("counting")]
        public bool counting
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
                                           id?.ToString() +
                                           (counting == true).ToString();
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
