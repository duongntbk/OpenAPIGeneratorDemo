using System;
using System.Text.Json.Serialization;

namespace Maritimum.Models
{
    public class Ship
    {
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("home_port_uuid")]
        public Guid HomePortUuid { get; set; }

        [JsonPropertyName("tonnage")]
        public int? Tonnage { get; set; }

        public Ship Clone() => new Ship
        {
            Uuid = Uuid,
            Name = Name,
            HomePortUuid = HomePortUuid,
            Tonnage = Tonnage,
        };
    }
}
