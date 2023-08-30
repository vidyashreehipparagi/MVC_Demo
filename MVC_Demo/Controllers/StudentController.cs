using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;
using MVC_Demo.Views;

namespace MVC_Demo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentList()
        {
            List<Student> students = new List<Student>()
            {
                new Student{ Id = 1,Sname="Vidyashree",Marks=50},
                new Student{ Id = 2,Sname="Akshata",Marks=60},
                new Student{ Id = 3,Sname="Anjali",Marks=70},
                new Student{ Id = 4,Sname="Pankaj",Marks=80},
                new Student{ Id = 5,Sname="Sagar",Marks=90},
                new Student{ Id = 6,Sname="Snehal",Marks=95}
            };
            ViewData["list"] = students;
            return View();
        }
    }
}
