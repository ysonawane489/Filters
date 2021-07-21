using Filters.Bussness;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Controllers
{
    public class ActionFilterController : Controller
    {   [ValidateModel]
        public IActionResult ActionFilterTest(string name)
        {
            return View();
        }
    }
}
