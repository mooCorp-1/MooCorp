using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StevenClarkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult YourMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PrintMessage()
        {
            string msg = HttpContext.Request.Form["Text1"].ToString();
            ViewBag.Messages = msg.ToString();
            return View("YourMessage");
        }
    }
}