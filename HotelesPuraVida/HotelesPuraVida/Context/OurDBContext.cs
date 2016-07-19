using HotelesPuraVida.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelesPuraVida.Context
{
    public class OurDBContext:DbContext
    {
        public DbSet<Login> UserAccout { get; set; }
    }
}