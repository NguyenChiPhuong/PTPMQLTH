using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class DiemTBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    [HttpPost]
    public IActionResult Index(DiemTb Tb)
    {
        //Tính điểm trung bình
        Tb.DiemTB = Tb.DiemA*0.6 + Tb.DiemB*0.3 + Tb.DiemC*0.1;
        string strOutput = "Điểm trung bình của bạn là:" +  Tb.DiemTB;
        ViewBag.DiemTb = strOutput;
        return View();
        }
    }
}