using Microsoft.AspNetCore.Mvc;

namespace MeowPlanet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
