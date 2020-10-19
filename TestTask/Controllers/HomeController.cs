using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestTask.Models;

namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task< IActionResult> Index()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=London&units=metric&appid=820325f3e470649a5d09e482df8a8871";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string response;
            using(StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = await streamReader.ReadToEndAsync();
            }
            return View();
        }

        
    }
}
