using Microsoft.AspNetCore.Mvc;

namespace RoleBasedAuthApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
