using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class StringMath : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NameConcatonation(string inputNumber1, int inputNumber2)
        {
            int difference = Math.Abs(inputNumber1.Length - inputNumber2);
            return View(viewName: "Index", model: difference);
        }
    }
}

