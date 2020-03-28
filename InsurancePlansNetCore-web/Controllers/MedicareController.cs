using Microsoft.AspNetCore.Mvc;

namespace InsurancePlansNetCore_web.Controllers
{
    public class MedicareController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}