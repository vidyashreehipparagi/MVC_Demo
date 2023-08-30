using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ Id = 1,Name="Pen",Price=20.20},
                new Product{ Id = 2,Name="Pencil",Price=10.20},
                new Product{ Id = 3,Name="MOuse",Price=30.20},
                new Product{ Id = 4,Name="Book",Price=20.20},
                new Product{ Id = 5,Name="Keyboard",Price=20.20},
                new Product{ Id = 6,Name="Pendrive",Price=20.20}
            };
            ViewData["list"] = products;
            ViewBag.List = products;

            return View();
        }
    }
}
