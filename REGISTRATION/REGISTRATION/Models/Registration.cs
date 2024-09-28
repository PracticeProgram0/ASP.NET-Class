using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REGISTRATION.Models
{
    public class Registration
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}