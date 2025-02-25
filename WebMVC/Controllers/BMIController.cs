using System.Runtime.Intrinsics.X86;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMI bmi)

        {
            if (bmi.Height <= 0 || bmi.Weight <= 0)
            {
                ViewBag.Thongb = "Chieu cao hoac can nang khong hop le";
                return View();
            }
            bmi.CSBMI = bmi.Weight / (bmi.Height * bmi.Height);
            string category;

            if (bmi.CSBMI < 18.5) category = "Gầy";
            else if (bmi.CSBMI < 24.9) category = "Bình thường";
            else if (bmi.CSBMI < 29.9) category = "Thừa cân";
            else category = "Béo phì";
            {

            string strOutput = "Chi so BMI cua " + bmi.Name + " la" + bmi.CSBMI  + " va duoc xep vao nhom " + category;
            ViewBag.BMI = strOutput;
            return View();
            }

    }
}
}
