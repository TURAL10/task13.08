using Microsoft.AspNetCore.Mvc;

namespace task13._08.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
            //return File("", "");
        }
    }
}
