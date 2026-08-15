using Microsoft.AspNetCore.Mvc;

namespace web1.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}