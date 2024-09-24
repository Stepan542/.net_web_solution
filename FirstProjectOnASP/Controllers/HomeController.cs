using Microsoft.AspNetCore.Mvc;

namespace FirstProjectOnASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
