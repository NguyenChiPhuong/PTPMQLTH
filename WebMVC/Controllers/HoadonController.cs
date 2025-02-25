using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class HoadonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Hoadon hd)
        {
            hd.ThanhTien = hd.DonGia * hd.SoLuong;
            string strOutput = "Tên sản phẩm: " + hd.TenSanPham + " Đơn giá: " + hd.DonGia + " Số lượng: " + hd.SoLuong + " Thành tiền: " + hd.ThanhTien;
            ViewBag.Hoadon = strOutput;
            return View();
        }
    }
}