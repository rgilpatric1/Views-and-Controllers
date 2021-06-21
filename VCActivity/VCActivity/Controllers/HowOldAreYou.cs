using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class HowOldAreYou : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SayAge(DateTime inputBirthday)
        {
            int a = DateTime.Now.Year - inputBirthday.Year - 1;
            if(DateTime.Now.Month > inputBirthday.Month || (DateTime.Now.Month == inputBirthday.Month && DateTime.Now.Day >= inputBirthday.Day))
            {
                a++;
            }
            return View(viewName: "Index", model: "Your age is: " + a);
        }
    }
}
