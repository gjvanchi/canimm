namespace WebApp.Models
{
    public class InterestByUniversity
    {
        public int Id { get; set; }
        public University University { get; set; }
        public User User { get; set; }
    }
}
