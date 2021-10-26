using System;
using System.Text.Json.Serialization;

namespace Maritimum.Requests
{
    public class ShipReportRequest
    {
        [JsonPropertyName("home_port_uuid")]
        public Guid HomePortUuid { get; set; }

        [JsonPropertyName("min_tonnage")]
        public int? MinTonnage { get; set; }

        [JsonPropertyName("max_tonnage")]
        public int? MaxTonnage { get; set; }
    }
}
