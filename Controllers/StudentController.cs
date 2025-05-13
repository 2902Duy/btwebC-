using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new List<Student>();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowKQ(Student model)
        {
            if (ModelState.IsValid)
            {
                students.Add(model);
                int sameMajorCount = students.Count(s => s.ChuyenNganh == model.ChuyenNganh);

                ViewBag.MSSV = model.MSSV;
                ViewBag.HoTen = model.HoTen;
                ViewBag.ChuyenNganh = model.ChuyenNganh;
                ViewBag.SoLuong = sameMajorCount;

                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
