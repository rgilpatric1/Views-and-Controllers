using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class StringAndMathMethodsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SayAbsoluteValue(string lastName, int age)
        {
            return View(viewName: "Index", model: "The absolute value of the length of your last name subtracted by your age is: " + (Math.Abs(lastName.Length - age)));
        }
    }
}
