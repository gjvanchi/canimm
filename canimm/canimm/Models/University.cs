﻿namespace WebApp.Models
{
    public class University
    {
        public int Id { get; set; }
        public string UniversityName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

        public Country Country { get; set; }
    }
}
