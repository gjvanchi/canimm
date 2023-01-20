namespace WebApp.Models
{
    public class InterestByCountry
    {
        public int Id { get; set; }
        public Country CountryCode { get; set; }
        public User User { get; set; }
    }
}
