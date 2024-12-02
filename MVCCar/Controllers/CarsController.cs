using Microsoft.AspNetCore.Mvc;

namespace MVCCar.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
