using Microsoft.EntityFrameworkCore;
using ProjectBanQuanAo.Models;

namespace ProjectBanQuanAo.Repository
{
    public class SeedData
    {

        public static void SeedingData(DataContext _context)
        {
            _context.Database.Migrate();
            if (!_context.Products.Any())
            {
                Category macbook = new Category { name = "Aplle", slug = "apple", description = "Good ok", status = "g" };
                Category desktop = new Category { name = "Samsung", slug = "Samsung", description = "very good ok", status = "g" };

                Brand apple = new Brand { name = "Samsung", slug = "Samsung", description = "very good ok", status = "g" };
                Brand samsung = new Brand { name = "Aplle", slug = "apple", description = "Good ok", status = "g" };
                _context.Products.AddRange(
                    new Product { name = "MacBook", slug = "Apple", description = "the best", Category = macbook, Price = 2, brand = apple },
                    new Product { name = "PC", slug = "desktop", description = "the best", Category = desktop, Price = 1, brand = samsung }
                );
                _context.SaveChanges();
            }
        }
    } }
        
  
