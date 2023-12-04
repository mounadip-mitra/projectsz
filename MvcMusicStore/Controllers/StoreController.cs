using Microsoft.AspNetCore.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
