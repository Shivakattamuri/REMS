using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REMS.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string PropertyTypeId { get; set; }

        public string Status { get; set; }

        public string Location { get; set; }

        public int? Bedrooms { get; set; }

        public int? Bathrooms { get; set; }

        public int? Floors { get; set; }

        public string Area { get; set; }

        public string Size { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Features { get; set; } 

        public string Address { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
    }
}
