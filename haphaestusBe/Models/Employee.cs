using System.Collections.Generic;

namespace haphaestusBe.Models
{
    public class Employee
    {
        public int Id { get; }

        public PersonName Name { get; }

        public bool IsSpouseEnabled { get; }

        public PersonName Spouse { get; }

        public IReadOnlyList<PersonName> Dependents { get; }

        public Employee(
            int id,
            PersonName name,
            bool isSpouseEnabled,
            PersonName spouse,
            IReadOnlyList<PersonName> dependents)
        {
            // TODO Guards

            Id = id;
            Name = name;
            IsSpouseEnabled = isSpouseEnabled;
            Spouse = spouse;
            Dependents = dependents;
        }
    }
}
