using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class StringActivityController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: "Please enter a string.");
        }
        [HttpPost]
        public async Task<IActionResult> SayHello(string inputString)
        {
            return View(viewName: "Index", model: "Hello " + inputString);
        }

        public async Task<IActionResult> StringLength(string inputString)
        {
            return View(viewName: "Index", model: "Input length:" + inputString.Length);
        }

    }
}
