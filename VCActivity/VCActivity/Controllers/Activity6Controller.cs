using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class Activity6Controller : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: "Please enter a string.");
        }
        public async Task<IActionResult> FindFullName(String firstName, String lastName)
        {
            return View(viewName: "Index", model: firstName + " " + lastName);
        }
    }
}
