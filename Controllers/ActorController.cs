using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            var actors = new List<Actor>
     {
         new Actor {Id = 1, Name="Hela", Role="hihi" },
         new Actor {Id = 2, Name="Zele", Role="hh" },
         new Actor {Id = 3, Name="ka", Role="hhi" }

     };
            return View(actors);
        }
    }
}
