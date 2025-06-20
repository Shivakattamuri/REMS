using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REMS.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Type { get; set; }  // Apartment, Villa, etc.
        public string Status { get; set; } // Sale, Rent, Both
        public decimal Price { get; set; }
        public string Description { get; set; }

        public int PostedByUserId { get; set; }
        public virtual User PostedBy { get; set; }
    }

}