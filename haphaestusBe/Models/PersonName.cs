namespace haphaestusBe.Models
{
    public class PersonName
    {
        public string FirstName { get; }

        public string LastName { get; }

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
