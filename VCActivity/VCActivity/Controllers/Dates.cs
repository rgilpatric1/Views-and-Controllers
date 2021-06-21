using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class Dates : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: DateTime.Now);
        }
        [HttpPost]
        public async Task<IActionResult> DateMagic(DateTime inputBirthday)
        {
            return View(viewName: "Index", model: inputBirthday);
        }
        public async Task<IActionResult> DisplayYears(DateTime inputBirthday)
        {
            return View(viewName: "Index", model: "The year someone was born is" + (2021 - (DateTime.Now.Year - inputBirthday.Year)));
        }
        public async Task<IActionResult> DisplayYearPresidentialElection(DateTime inputBirthday)
        {
            return View(viewName: "Index", model: "The age of the person in the 2024 presidential election is" + (2021 - (DateTime.Now.Year - inputBirthday.Year + 3)));
        }
       
}
}
