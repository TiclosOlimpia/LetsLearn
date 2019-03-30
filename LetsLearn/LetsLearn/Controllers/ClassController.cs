using Microsoft.AspNetCore.Mvc;

namespace LetsLearn.Controllers
{
    public class ClassController : Controller
    {
        // GET
        public IActionResult Clasa()
        {
            ViewBag.clasa = Request.Cookies["clasa"].ToString();
            return View();
        }
    }
}