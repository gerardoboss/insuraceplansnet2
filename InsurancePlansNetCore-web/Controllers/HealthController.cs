using Microsoft.AspNetCore.Mvc;

namespace InsurancePlansNetCore_web.Controllers
{
    public class HealthController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}