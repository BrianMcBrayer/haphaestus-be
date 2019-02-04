using MongoDB.Bson.Serialization.Attributes;

namespace haphaestusBe.Models
{
    public class PersonName
    {
        [BsonElement]
        public string FirstName { get; set;  }

        [BsonElement]
        public string LastName { get; set;  }

        public PersonName(
            string firstName,
            string lastName)
        {
            // TODO Guards

            FirstName = firstName;
            LastName = lastName;
        }
    }
}
