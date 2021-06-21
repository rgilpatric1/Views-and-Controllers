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
            return View(viewName: "Index", model: DateTime.Now.Year);
        }
        [HttpPost]
        public async Task<IActionResult> DateMagic(DateTime inputBirthday)
        {
            int birthYear = inputBirthday.Year;
            int yearsOld = DateTime.Now.Year - birthYear;
            int numLeapYears = yearsOld / 4;
            if(yearsOld % 4 == 1)
            {
                numLeapYears++;
            }
            else if(yearsOld % 4 == 2)
            {
                numLeapYears++;
            }
            else if(yearsOld % 4 == 3)
            {
                numLeapYears++;
            }
            return View(viewName: "Index", model: numLeapYears);
        }
    }
}
