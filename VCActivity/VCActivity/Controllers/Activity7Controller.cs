using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCActivity.Controllers
{
    public class Activity7Controller : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(viewName: "Index", model: -999);
        }
        public async Task<IActionResult> absValDiff(String lastName, int age)
        {
            int nameLength = lastName.Length;
            int diff = -999;
            if(age > nameLength)
            {
                diff = age - nameLength;
            }
            else
            {
                diff = nameLength - age;
            }
            return View(viewName: "Index", model: diff);
        }
    }
}
