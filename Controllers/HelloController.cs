using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello, World!";  
            ViewData.Add("Greeting", "Welcome to ASP.NET Core MVC!");
            var student = new { Id = 1, Name = "John Doe" };

            return View(student);
        }
    }
}
