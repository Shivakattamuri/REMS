using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REMS.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; } // Admin, Manager, Buyer
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
