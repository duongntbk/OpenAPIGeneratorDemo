using System;

namespace SampleApi.Models
{
    public class Person : ICloneable<Person>, IFindable
    {
        public Guid Uuid { get; set; }

        public string Name { get; set; }

        public int? Age => CalculateAge();

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
