using Microsoft.AspNetCore.Mvc;
using web1.Models;

namespace web1.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddModel obj)
        {
            obj.Answer = obj.No1 + obj.No2;
            return View(obj);
        }
    }
}