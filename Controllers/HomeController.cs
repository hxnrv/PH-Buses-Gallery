using frontend_activity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace frontend_activity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DMMW()
        {
            return View();
        }

        public IActionResult Santarosa()
        {
            return View();
        }

        public IActionResult Higer()
        {
            return View();
        }

        public IActionResult Yutong()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
