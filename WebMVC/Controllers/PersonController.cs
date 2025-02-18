using Microsoft.AspNetCore.Mvc;
using WebMvc.Models;
namespace WebMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strOutput = "Xin chao " + ps.PersonId + "-" + ps.FullName + " den tu " + ps.Address;
        ViewBag.Person = strOutput;
        return View();
    }
    
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}
}