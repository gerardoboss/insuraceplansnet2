using Microsoft.AspNetCore.Mvc;

namespace InsurancePlansNetCore_web.Controllers
{
    public class LifeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}