using Microsoft.AspNetCore.Mvc;

namespace InsurancePlansNetCore_web.Controllers
{
    public class HomeInsuranceController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}