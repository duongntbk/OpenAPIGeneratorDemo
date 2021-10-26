using System;
using System.Text.Json.Serialization;

namespace Maritimum.Models
{
    public class Port
    {
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("is_deep_water")]
        public bool? IsDeepWater { get; set; }

        public Port Clone() => new Port
        {
            Uuid = Uuid,
            Name = Name,
            Country = Country,
            IsDeepWater = IsDeepWater
        };
    }
}
