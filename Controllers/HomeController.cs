using BackendforFrontEnd.Models;
using BackendforFrontEnd.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BackendforFrontEnd.Controllers
{
    public class HomeController(ILogger<HomeController> logger, IBffService bffService) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly IBffService _bffService = bffService;

        public async Task<IActionResult> Index()
        {
            var flights = await _bffService.GetFlightsAsync();
            return View(flights);
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
