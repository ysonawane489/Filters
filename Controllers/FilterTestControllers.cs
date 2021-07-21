using Microsoft.AspNetCore.Mvc;
using static Filters.Bussness.AuthorizeActionFilter;

namespace Filters.Controllers
{
    public class FilterTestControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize("Read")]

        public IActionResult Read()
        {
            return View();

        }
        [Authorize("Write")]

        public IActionResult Edit()
        {
            return View();

        }
    }
}
