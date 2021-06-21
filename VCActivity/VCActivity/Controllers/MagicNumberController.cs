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
            return View(viewName: "Index", model: "Please enter an integer");
        }
        public async Task<IActionResult> IndexOne()
        {
            return View(viewName: "Index", model: "Please enter an integer");
        }
        public async Task<IActionResult> SayMagicNumber(int inputNumberOne, int inputNumberTwo)
        {
            Random rnd = new Random();
            return View(viewName: "Index", model: "Magic Number is" + rnd.Next(inputNumberOne, inputNumberTwo);
        }
        public async Task<IActionResult> OrderofNumbers
       
    }
}
