using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class FirstAndLastNameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SayName(string firstName, string lastName)
        {
            return View(viewName: "Index", model: "Your name is: " + firstName + " " + lastName);
        }
    }
}
