using Microsoft.AspNetCore.Mvc;
using task13._08.Models;

namespace task13._08.Controllers
{
    public class HomeController : Controller
    {

        private List<Student> students = new List<Student>()
        {
            new(){Id = 1,Name="Messi",Age=36},
            new(){Id = 2,Name="Ronaldo",Age=38},
            new(){Id = 3,Name="Neymar",Age=31},


        };
        
        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult About(int id)
        {
            return View(students.Find(s => s.Id == id));
        }
    }
}
