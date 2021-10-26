using System;
using System.Text.Json.Serialization;

namespace Pecunia.Models
{
    public class Person : ICloneable<Person>, IFindable
    {
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int? Age => CalculateAge();

        [JsonPropertyName("dob")]
        public DateTime? Dob { get; set; }

        public Person Clone() => new Person
        {
            Uuid = Uuid,
            Name = Name,
            Dob = Dob
        };

        private int? CalculateAge()
        {
            if (Dob is null)
            {
                return null;
            }

            var now = DateTime.Now;
            var diffYear = now.Year - Dob.Value.Year;

            if ((now.Month * 100 + now.Day) < (Dob.Value.Month * 100 + Dob.Value.Day))
            {
                diffYear--;
            }

            return diffYear;
        }
    }
}
