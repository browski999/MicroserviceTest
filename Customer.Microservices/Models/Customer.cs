namespace Customer.Microservices.Models
{
    public class Customer : Entity
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string EmailAddress { get; set; }
    }
}
