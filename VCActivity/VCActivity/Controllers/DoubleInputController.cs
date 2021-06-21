using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class DoubleInputController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> NameConcatonation(string inputNumber1, string inputNumber2)
        {
            return View(viewName: "Index", model: inputNumber1 + " " + inputNumber2);
        }
    }
}
