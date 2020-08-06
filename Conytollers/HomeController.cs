using Microsoft.AspNetCore.Mvc;
using System;
using TimeDisplay;
namespace TimeDisplay.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime;
            return View();
        }
    }
}