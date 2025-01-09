using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using tt0103.Models;

namespace tt0103.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ESQtempdatabasedbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ESQtempdatabasedbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var res = _dbContext.Records.ToList();
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        public IActionResult Vendor()
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
