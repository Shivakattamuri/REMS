using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using REMS.Controllers.REMS.Controllers;

namespace REMS.Models
{
    public class PropertyType
    {

        public int PropertyTypeId { get; set; }
        public string PropertyTypeName { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
