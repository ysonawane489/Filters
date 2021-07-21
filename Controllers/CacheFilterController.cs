using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Filters.Bussness.CacheResourceFilter;

namespace Filters.Controllers
{
    public class CacheFilterController : Controller
    {
        [CacheResource]
        public IActionResult CacheTest()
        {
            return Content("This content was genratedbat " + DateTime.Now);
        }
    }
}
