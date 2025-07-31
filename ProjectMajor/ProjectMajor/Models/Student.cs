﻿namespace ProjectMajor.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public College College { get; set; }
        public int CollegeId { get; set; }
    }
}
