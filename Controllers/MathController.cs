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
            ViewBag.Answer = No1 + No2;
            ViewBag.No1 = No1;
            ViewBag.No2 = No2;

            // 也可以用 ViewData["Answer"] = No1 + No2;
            // cshtml 中用 @ViewData["Answer"] 取值
            return View();
        }
    }
}