﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using REMS.Models;

namespace REMS.Models
{
    public class REMSDBContext : DbContext
    {
        public REMSDBContext() : base("name=REMSDbContext") { }

        public DbSet<Property> Properties { get; set; }
    }
}
