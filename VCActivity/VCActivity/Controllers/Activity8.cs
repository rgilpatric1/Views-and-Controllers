using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class Activity8 : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public async Task<IActionResult> age(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Month == birthday.Month)
            {
                if (DateTime.Now.Day < birthday.Day)
                {
                    age--;
                }
            }
            if (DateTime.Now.Month < birthday.Month)
            {
                age--;
            }

            return View(viewName: "Index", model: age);
        }
    }
}
