using lr6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace lr6.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Register()
        {
            return View("~/Views/Home/Register.cshtml");
        }

        [HttpPost]
        public IActionResult Register(User user, int productCount)
        {
            if (user.Age > 16)
            {
                return RedirectToAction("Order", new { count = productCount });
            }
            return View("~/Views/Home/Register.cshtml");
        }

        public IActionResult Order(int count)
        {
            var products = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                products.Add(new Product());
            }
            ViewBag.MenuItems = GetAvailableProducts(); // Використання коректного методу для отримання продуктів
            return View("~/Views/Home/Order.cshtml", products);
        }

        [HttpPost]
        public IActionResult Summary(List<Product> products)
        {
            return View("~/Views/Home/Summary.cshtml", products);
        }

        
        private List<MenuItem> GetAvailableProducts()
        {
            return new List<MenuItem>
            {
                new MenuItem { Name = "Кава", Price = 30 },
                new MenuItem { Name = "Піцца", Price = 80 },
                new MenuItem { Name = "Чай", Price = 20 },
                new MenuItem { Name = "Салат", Price = 50 }
            };
        }
    }
}
