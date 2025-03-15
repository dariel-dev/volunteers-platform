using Microsoft.AspNetCore.Mvc;
using VolunteersPlatform.Models;

namespace VolunteersPlatform.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Volunteer()
        {
            return View();
        }

        public IActionResult Provider()
        {
            return View();
        }
    }
}