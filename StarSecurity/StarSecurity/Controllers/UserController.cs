using Microsoft.AspNetCore.Mvc;
using StarSecurity.Models;
using System.Reflection.Metadata.Ecma335;

namespace StarSecurity.Controllers
{
    public class UserController : Controller
    {
        private readonly StarSecurityDbContext _context;

        public UserController(StarSecurityDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Services.ToList());
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View(_context.Services.ToList());
        }

        public IActionResult Testimonials()
        {
            return View(_context.Testimonials.ToList());
        }

    }
}
