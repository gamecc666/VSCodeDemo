using Microsoft.AspNetCore.Mvc;

namespace 后台调用前台方法.Controllers
{
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {        
            return View();
        }
    }
}
