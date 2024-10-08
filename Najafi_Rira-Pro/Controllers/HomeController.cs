using Microsoft.AspNetCore.Mvc;


namespace Najafi_Rira_Pro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
