using Microsoft.AspNetCore.Mvc;

using lr8.Models;

    public class ProductController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>
            {
                new Product { ID = 1, Name = "Galaxy S21", Price = 799.99m, CreatedDate = DateTime.Now.AddMonths(-22) },
                new Product { ID = 2, Name = "iPhone 13", Price = 999.99m, CreatedDate = DateTime.Now.AddMonths(-22) },
                new Product { ID = 3, Name = "Google Pixel 6", Price = 699.99m, CreatedDate = DateTime.Now.AddDays(-10) }
            };

        return View(products); 
    }
}
