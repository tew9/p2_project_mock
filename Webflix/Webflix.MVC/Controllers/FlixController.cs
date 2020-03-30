using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Webflix.MVC.Models;

namespace Webflix.MVC.Controllers
{
    public class FlixController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HttpClient _client = new HttpClient();

        public FlixController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var res = _client.GetStringAsync("http://api/flix").GetAwaiter().GetResult();
            var films = JsonConvert.DeserializeObject<List<FlixViewModel>>(res);
            return View(films);
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
