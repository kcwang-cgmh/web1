using Microsoft.AspNetCore.Mvc;

namespace web1.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(int No1, int No2)
        {
            ViewData["Answer"] = No1 + No2;
            ViewData["No1"] = No1;
            ViewData["No2"] = No2;

            return View();
        }
    }
}