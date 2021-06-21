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
            return View(viewName: "Index", model: "Hello " + inputString + " Length of String" + inputString.Length);
        }
        public async Task<IActionResult> Input(int inputRating)
        {
            return View(viewName: "Index", model: "Please enter on a scale from 1-10 on how handsome you think you are");
        }
        public async Task<IActionResult> SayHandsome(int inputRating)
        {

            if (inputRating > 1 && inputRating < 5)
            {
                return View(model: "Good luck getting a girlfriend");
            }
            else if (inputRating > 6 && inputRating < 8)
            {
                return View(model: "Decent");
            }
            else
            {
                return View(model: "Your level of handsomeness is good but not as good as Sumanth Kota");
            }
        }
    }
}
