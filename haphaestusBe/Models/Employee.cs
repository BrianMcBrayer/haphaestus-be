using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace haphaestusBe.Models
{
    public class Employee
    {
        [BsonElement]
        [BsonId]
        public int? Id { get; set;  }

        [BsonElement]
        public PersonName Name { get; set;  }

        [BsonElement]
        public bool IsSpouseEnabled { get; set;  }

        [BsonElement]
        public PersonName Spouse { get; set;  }

        [BsonElement]
        public IReadOnlyList<PersonName> Dependents { get; set;  }

        public Employee(
            int? id,
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
