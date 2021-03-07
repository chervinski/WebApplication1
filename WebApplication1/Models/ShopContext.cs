using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    class ShopContext : DbContext
    {
        public ShopContext() : base("DbConnection") { }
        public DbSet<Product> Products { get; set; }
    }
}