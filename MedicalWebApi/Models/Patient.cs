﻿namespace MedicalWebApi.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
    }
}
