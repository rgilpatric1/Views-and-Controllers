using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class DatesController : Controller
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
        public async Task<IActionResult> AgeToday(DateTime inputBirthday)
        {
            var age = DateTime.Now.Year - inputBirthday.Year;
            if(inputBirthday.Date > DateTime.Now.AddYears(-age))
            {
                return View(viewName: "Index", model: age-1);
            }
            return View(viewName: "Index", model: age);
        }

        public async Task<IActionResult> LeapYears(DateTime inputBirthday)
        {
            var totalLeapYears = 0;
            var year = inputBirthday.Date.Year;
            if (inputBirthday.Date.Year % 4 == 0)
            {
                totalLeapYears = totalLeapYears + 1;
            }
            year = year + 4;
            while (year <= DateTime.Now.Year)
            {
                totalLeapYears = totalLeapYears + 1;
                year = year + 4;
            }
            return View(viewName: "Index", model: totalLeapYears);

        }
    }
}
