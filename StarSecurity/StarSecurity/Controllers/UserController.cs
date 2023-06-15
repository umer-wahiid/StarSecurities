using Microsoft.AspNetCore.Mvc;

namespace StarSecurity.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}
