using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Controllers
{
    public class CustomExceptionController : Controller
    {
        public IActionResult GenerateError()
        {
            throw new NotImplementedException();
        }
    }
}
