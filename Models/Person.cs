namespace BetterSchoolAPI.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelephoneNumber { get; set; }
        public string Mail { get; set; }
    }
}
