using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Linq;

namespace DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections
{
    [XmlRoot("DirectionResponse")]
    [Newtonsoft.Json.JsonObject(Title = "DirectionResponse")]
    public class DirectionsResponse
    {
        [XmlElement("status")]
        [Newtonsoft.Json.JsonProperty("status")]
        public string status
        {
            get;
            set;
        }
        [XmlElement("geocoded_waypoints")]
        [Newtonsoft.Json.JsonProperty("geocoded_waypoints")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Geocoded_waypoints[] geocoded_waypoints
        {
            get;
            set;
        }
        [XmlElement("Routes")]
        [Newtonsoft.Json.JsonProperty("Routes")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Route[] Routes
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
                                           geocoded_waypoints?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           Routes?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("Geocoded_waypoints")]
    public class Geocoded_waypoints
    {
        [XmlElement("geocoder_status")]
        [Newtonsoft.Json.JsonProperty("geocoder_status")]
        public string geocoder_status
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
        public System.Collections.Generic.List<string> types
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
                                           geocoder_status?.ToString() +
                                           place_id?.ToString() +
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
    [XmlRoot("Route")]
    public class Route
    {
        [XmlElement("summary")]
        [Newtonsoft.Json.JsonProperty("summary")]
        public string summary
        {
            get;
            set;
        }
        [XmlElement("legs")]
        [Newtonsoft.Json.JsonProperty("legs")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Leg[] legs
        {
            get;
            set;
        }
        [XmlElement("duration")]
        [Newtonsoft.Json.JsonProperty("duration")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Duration duration
        {
            get;
            set;
        }
        [XmlElement("distance")]
        [Newtonsoft.Json.JsonProperty("distance")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Distance distance
        {
            get;
            set;
        }
        [XmlElement("start_location")]
        [Newtonsoft.Json.JsonProperty("start_location")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Location start_location
        {
            get;
            set;
        }
        [XmlElement("end_location")]
        [Newtonsoft.Json.JsonProperty("end_location")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Location end_location
        {
            get;
            set;
        }
        [XmlElement("start_address")]
        [Newtonsoft.Json.JsonProperty("start_address")]
        public string start_address
        {
            get;
            set;
        }
        [XmlElement("end_address")]
        [Newtonsoft.Json.JsonProperty("end_address")]
        public string end_address
        {
            get;
            set;
        }
        [XmlElement("copyrights")]
        [Newtonsoft.Json.JsonProperty("copyrights")]
        public string copyrights
        {
            get;
            set;
        }
        [XmlElement("overview_polyline")]
        [Newtonsoft.Json.JsonProperty("overview_polyline")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Polyline overview_polyline
        {
            get;
            set;
        }
        [XmlElement("waypoint_order")]
        [Newtonsoft.Json.JsonProperty("waypoint_order")]
        public System.Collections.Generic.List<int?> waypoint_order
        {
            get;
            set;
        }
        [XmlElement("bounds")]
        [Newtonsoft.Json.JsonProperty("bounds")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Bound bounds
        {
            get;
            set;
        }
        [XmlElement("Warnings")]
        [Newtonsoft.Json.JsonProperty("Warnings")]
        public string[] Warnings
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
                                           summary?.ToString() +
                                           legs?.Sum(x => x?._CalculatedKey)?.ToString() +
                                           duration?._CalculatedKey?.ToString() +
                                           distance?._CalculatedKey?.ToString() +
                                           start_location?._CalculatedKey?.ToString() +
                                           end_location?._CalculatedKey?.ToString() +
                                           start_address?.ToString() +
                                           end_address?.ToString() +
                                           copyrights?.ToString() +
                                           overview_polyline?._CalculatedKey?.ToString() +
                                           waypoint_order?.ToList()?.Count().ToString() +
                                           bounds?._CalculatedKey?.ToString() +
                                           Warnings?.ToList()?.Count().ToString();
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
    [XmlRoot("Leg")]
    public class Leg
    {
        [XmlElement("steps")]
        [Newtonsoft.Json.JsonProperty("steps")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Step[] steps
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
                                           steps?.Sum(x => x?._CalculatedKey)?.ToString();
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
    [XmlRoot("Step")]
    public class Step
    {
        [XmlElement("travel_mode")]
        [Newtonsoft.Json.JsonProperty("travel_mode")]
        public string travel_mode
        {
            get;
            set;
        }
        [XmlElement("start_location")]
        [Newtonsoft.Json.JsonProperty("start_location")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Location start_location
        {
            get;
            set;
        }
        [XmlElement("end_location")]
        [Newtonsoft.Json.JsonProperty("end_location")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Location end_location
        {
            get;
            set;
        }
        [XmlElement("polyline")]
        [Newtonsoft.Json.JsonProperty("polyline")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Polyline polyline
        {
            get;
            set;
        }
        [XmlElement("duration")]
        [Newtonsoft.Json.JsonProperty("duration")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Duration duration
        {
            get;
            set;
        }
        [XmlElement("html_instructions")]
        [Newtonsoft.Json.JsonProperty("html_instructions")]
        public string html_instructions
        {
            get;
            set;
        }
        [XmlElement("distance")]
        [Newtonsoft.Json.JsonProperty("distance")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Distance distance
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
                                           travel_mode?.ToString() +
                                           start_location?._CalculatedKey?.ToString() +
                                           end_location?._CalculatedKey?.ToString() +
                                           polyline?._CalculatedKey?.ToString() +
                                           duration?._CalculatedKey?.ToString() +
                                           html_instructions?.ToString() +
                                           distance?._CalculatedKey?.ToString();
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
    [XmlRoot("Location")]
    public class Location
    {
        [XmlElement("lat")]
        [Newtonsoft.Json.JsonProperty("lat")]
        public float? lat
        {
            get;
            set;
        }
        [XmlElement("lng")]
        [Newtonsoft.Json.JsonProperty("lng")]
        public float? lng
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
    [XmlRoot("Polyline")]
    public class Polyline
    {
        [XmlElement("points")]
        [Newtonsoft.Json.JsonProperty("points")]
        public string points
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
                                           points?.ToString();
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
    [XmlRoot("Duration")]
    public class Duration
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
    [XmlRoot("Distance")]
    public class Distance
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
        public string value
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
    [XmlRoot("Bound")]
    public class Bound
    {
        [XmlElement("southwest")]
        [Newtonsoft.Json.JsonProperty("southwest")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Location southwest
        {
            get;
            set;
        }
        [XmlElement("northeast")]
        [Newtonsoft.Json.JsonProperty("northeast")]
        public DSS2_SynchromodalityCapacityOptimisation.ExternalStructs.GoogleDirections.Location northeast
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
                                           southwest?._CalculatedKey?.ToString() +
                                           northeast?._CalculatedKey?.ToString();
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
