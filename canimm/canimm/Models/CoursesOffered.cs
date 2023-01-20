namespace WebApp.Models
{
    public class CoursesOffered
    {
        public int Id { get; set; }
        public University University { get; set ; }
        public Course Course { get; set; }
        public Department Department { get; set; }

    }
}
