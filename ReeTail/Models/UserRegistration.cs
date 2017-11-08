using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReeTail.Models
{
    public class UserRegistration
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string Postcode { get; set; }
        public string MobileNum { get; set; }
        public string ProfileImg { get; set; }

    }
}