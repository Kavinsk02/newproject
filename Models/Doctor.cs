using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication13.Models
{
    public class Doctor
    {
        public int Id { get; set; } 
        public string Imagepath { get; set; }
        public string Doctorname { get; set; } 
        public string Degree { get; set; }
        public string Phonenumber { get; set; } 
        public string Specialization { get; set; }

    }
}