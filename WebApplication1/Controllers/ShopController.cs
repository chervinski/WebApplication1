using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public static class ShopController
    {
        public static void AddProduct(string name, int count)
        {
            using (ShopContext db = new ShopContext())
            {
                db.Products.Add(new Product() { Name = name, Count = count });
                db.SaveChanges();
            }
        }
    }
}