using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDemo.Models
{
    public class TableDB
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

    }
    public class TableDBContext : DbContext
    {
        public DbSet<TableDB> Tables { get; set; }
    }
}