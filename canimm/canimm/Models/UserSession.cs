namespace WebApp.Models
{
    public class UserSession
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Session { get; set; }
    }
}
