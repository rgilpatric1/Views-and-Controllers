using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class SquareNumberController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public async Task<IActionResult> SaySquareRoot(double inputNumber)
        {
            return View(viewName: "Index", model: Math.Sqrt(inputNumber));
        }
    }
}