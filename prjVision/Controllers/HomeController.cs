using Microsoft.AspNetCore.Mvc;
using prjVision.Models;
using System.Diagnostics;

namespace prjVision.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VisionURL()
        {
            return View();
        }

        public IActionResult VisionByte()
        {
            return View();
        }

        public IActionResult VisionCustom()
        {
            return View();
        }

        public IActionResult LUIS()
        {
            return View();
        }

        public IActionResult Privacy()
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
