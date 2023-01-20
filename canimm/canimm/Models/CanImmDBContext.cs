

using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class CanImmDBContext : DbContext
    {
        public CanImmDBContext(DbContextOptions<CanImmDBContext> options) : base(options)
        {

        }
        public DbSet<Country> Country { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<CourseLevel> CourseLevel { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CoursesOffered> CourseOffered { get; set; }
        public DbSet<User> User {get; set;}
        public DbSet<UserType> UserType { get; set; }
        public DbSet<InterestByCountry> InterestByCountry { get; set; }
        public DbSet<InterestByCourse> InterestByCourse { get; set; }
        public DbSet<InterestByUniversity> InterstByUniversity { get; set; }
        public DbSet<UserSession> UserSession { get; set; }
    }
}
