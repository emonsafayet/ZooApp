﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ZooApp.Models
{
    public class ZooContext : DbContext
    {
        public ZooContext() : base("ZooContext")
        {

        }
        public DbSet<Animal> Animals { get; set; }
    }
}
