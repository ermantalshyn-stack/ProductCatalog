using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;
using System.Collections.Generic;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Ноутбук",
                    Price = 350000,
                    Category = "Электроника",
                    IsAvailable = true
                },

                new Product
                {
                    Id = 2,
                    Name = "Құлаққап",
                    Price = 15000,
                    Category = "Аксессуар",
                    IsAvailable = true
                },

                new Product
                {
                    Id = 3,
                    Name = "Пернетақта",
                    Price = 12000,
                    Category = "Аксессуар",
                    IsAvailable = false
                }
            };

            return View(products);
        }
    }
}