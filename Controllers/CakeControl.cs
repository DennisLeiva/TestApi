using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    public class CakeControl : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
