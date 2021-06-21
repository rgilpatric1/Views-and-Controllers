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
            return View(viewName: "Index", model: DateTime.Now.ToString());
        }
        [HttpPost]
        public async Task<IActionResult> DateMagic(DateTime inputBirthday)
        {
            string a = inputBirthday.ToString() + ", Year of Birth: " + inputBirthday.Year + ", Leap Years since your Birthday: " + numLeapyears(inputBirthday.Year);
            return View(viewName: "Index", model: a);
        }

        public int numLeapyears(int years)
        {
            int currentYear = DateTime.Now.Year;
            int count = 0;
            for(int i = years; i <= currentYear; i++)
            {
                if(i%4 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
