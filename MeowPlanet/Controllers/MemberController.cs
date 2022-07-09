using Microsoft.AspNetCore.Mvc;

namespace MeowPlanet.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
