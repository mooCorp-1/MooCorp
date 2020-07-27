using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ViewDetails()
        {
            CustomerDataModel cd = new CustomerDataModel();
            cd.Name = "Steven Clark";
            cd.Age = 34;
            ViewBag.Name = cd.Name;
            ViewBag.Age = Convert.ToString(cd.Age);
            return View("Index");
        }
    }
}