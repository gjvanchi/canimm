namespace WebApp.Models
{
    public class InterestByCourse
    {
        public int Id { get; set; }
        public Course Course { get; set; }
        public User User { get; set; }
    }
}
