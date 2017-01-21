using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDemo.Models
{
    public class ChairDB
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }

    public class ChairDBContext : DbContext
    {
        public DbSet<ChairDB> Chairs { get; set; }
    }
}