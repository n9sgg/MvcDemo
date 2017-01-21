using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDemo.Models
{
    public class AccessorieDB
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

    }
    public class AccessorieDBContext : DbContext
    {
        public DbSet<AccessorieDB> Accessories { get; set; }
    }
}