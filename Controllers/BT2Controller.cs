using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BT2Controller : Controller
    {
        public IActionResult Index()
        {
            var sanPhams = new SanPham { Id = 1, TenSanPham = "Sản phẩm 1", Gia = 1000, HinhAnh = "images/image_4.jpg" };
                
            return View(sanPhams);
        }
    }
}
