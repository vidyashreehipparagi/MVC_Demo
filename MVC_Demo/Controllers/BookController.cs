using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;
using MVC_Demo.Views;

namespace MVC_Demo.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book{ Bid = 1,Bname="Indian Geography",Price=200},
                new Book{ Bid = 2,Bname="Social Science",Price=260},
                new Book{ Bid = 3,Bname="Environmetal Studies",Price=670},
                new Book{ Bid = 4,Bname="English Grammer",Price=880},
                new Book{ Bid = 5,Bname="Information Technology",Price=980},
                new Book{ Bid = 6,Bname="Data Science",Price=955}
            };
            ViewData["list"] = books;

            return View();
        }
    }
}
