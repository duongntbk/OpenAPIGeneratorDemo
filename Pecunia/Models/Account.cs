using System;

namespace SampleApi.Models
{
    public class Account : ICloneable<Account>, IFindable
    {
        public Guid Uuid { get; set; }

        public Guid OnwerUuid { get; set; }

        public decimal Value { get; set; }

        public bool IsFrozen { get; set; }

        public Account Clone() => new Account
        {
            Uuid = Uuid,
            OnwerUuid = OnwerUuid,
            Value = Value,
            IsFrozen = IsFrozen
        };
    }
}
