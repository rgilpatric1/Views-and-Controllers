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
            return View(viewName: "Index", model: "Please enter your two numbers.");
        }
        [HttpPost]

        public async Task<IActionResult> MagicNumberGenerator(int inputNumber1, int inputNumber2)
        {
            Random ran = new Random();
            if(inputNumber1 >= inputNumber2)
            {
                return View(viewName: "Index", model: ran.Next(inputNumber2, inputNumber1));
            }
            else
            {
                return View(viewName: "Index", model: ran.Next(inputNumber1, inputNumber2));
            }
            
        }

    }
}
