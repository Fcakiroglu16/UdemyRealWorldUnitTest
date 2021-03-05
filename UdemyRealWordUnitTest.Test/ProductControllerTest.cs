using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyRealWordUnitTest.Web.Models;

namespace UdemyRealWordUnitTest.Test
{
    public class ProductControllerTest
    {
        protected DbContextOptions<UdemyUnitTestDBContext> _contextOptions { get; private set; }

        public void SetContextOptions(DbContextOptions<UdemyUnitTestDBContext> contextOptions)
        {
            _contextOptions = contextOptions;
            Seed();
        }

        public void Seed()
        {
            using (UdemyUnitTestDBContext context = new UdemyUnitTestDBContext(_contextOptions))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Category.Add(new Category { Name = "Kalemler" });
                context.Category.Add(new Category { Name = "Defterler" });
                context.SaveChanges();

                context.Product.Add(new Product() { CategoryId = 1, Name = "kalem 10", Price = 100, Stock = 100, Color = "Kırmızı" });
                context.Product.Add(new Product() { CategoryId = 1, Name = "kalem 20", Price = 100, Stock = 100, Color = "Mavi" });

                context.SaveChanges();
            }
        }
    }
}