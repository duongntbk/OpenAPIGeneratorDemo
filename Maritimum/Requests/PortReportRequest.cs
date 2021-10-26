using System.Text.Json.Serialization;

namespace Maritimum.Requests
{
    public class PortReportRequest
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("is_deep_water")]
        public bool? IsDeepWater { get; set; }
    }
}
