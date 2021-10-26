using System;
using System.Text.Json.Serialization;

namespace Pecunia.Models
{
    public class Account : ICloneable<Account>, IFindable
    {
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("owner_uuid")]
        public Guid OwnerUuid { get; set; }

        [JsonPropertyName("value")]
        public long Value { get; set; }

        [JsonPropertyName("is_frozen")]
        public bool IsFrozen { get; set; }

        public Account Clone() => new Account
        {
            Uuid = Uuid,
            OwnerUuid = OwnerUuid,
            Value = Value,
            IsFrozen = IsFrozen
        };
    }
}
