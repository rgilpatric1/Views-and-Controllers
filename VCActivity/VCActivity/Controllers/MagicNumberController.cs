using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class MagicNumberController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public async Task<IActionResult> FindMagicNumber(int number1, int number2)
        {
            Random generator = new Random();
            return View(viewName: "Index", model: generator.Next(number1, number2+1));
        }
    }
}
