using Microsoft.AspNetCore.Mvc;

namespace eCommerceKO.Areas.SysAdmin.Controllers
{
    [Area("SysAdmin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
