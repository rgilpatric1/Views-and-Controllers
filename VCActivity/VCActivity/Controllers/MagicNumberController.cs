using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class MagicNumberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SayMagicNumber(int inputNumber1, int inputNumber2)
        {
            return View(viewName: "Index", model: ((new Random()).Next(inputNumber1, inputNumber2+1)));
        }
    }
}
