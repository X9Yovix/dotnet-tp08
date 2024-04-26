using Microsoft.AspNetCore.Mvc;
using TP08.Models;

namespace TP08.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product produit = new Product()
            {
                Id = 1,
                Name = "Produit 1",
                Price = 10.5m
            };
            List<Product> produits = new List<Product>()
            {
                new Product()
                {
                    Id = 2,
                    Name = "Produit 2",
                    Price = 20.5m
                },
               new Product()
               {
                   Id = 3,
                   Name = "Produit 3",
                   Price = 30.5m
               }
            };
            return View(produits);
        }
    }
}
