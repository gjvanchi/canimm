using System;

namespace WebApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Country Country { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Qualification { get; set; }
    }
}
