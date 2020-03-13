using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Travquot.Models;

namespace Travquot.Controllers
{
    public class ToursController : Controller
    {
        private readonly ILogger<ToursController> _logger;

        public ToursController(ILogger<ToursController> logger)
        {
            _logger = logger;
        }

        public IActionResult Listing()
        {
            return View();
        }

        public IActionResult Details()
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
