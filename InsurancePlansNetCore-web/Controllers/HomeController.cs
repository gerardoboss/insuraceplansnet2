using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using InsurancePlansNetCoreData.Services;
using InsurnacePlansNetCore_data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using ErrorViewModel = InsurancePlansNetCore_web.Models.ErrorViewModel;

namespace InsurancePlansNetCore_web.Controllers
{
    public class IndexViewModel
    {
        public List<SelectListItem> Services { get; set; }
        public Lead Lead { get; set; }
        public string errorMessage { get; set; }
    }
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IInsuranceServicesServcie _insuranceServices;
        private readonly ICheckGeoLocationService _checkGeoLocationService;

        public HomeController(ILogger<HomeController> logger,IInsuranceServicesServcie insuranceService, ICheckGeoLocationService checkGeoLocationService)
        {
            _logger = logger;
            _insuranceServices = insuranceService;
            _checkGeoLocationService = checkGeoLocationService;
        }

        public IActionResult Index()
        {
            var insuranceServices = _insuranceServices.GetInsuranceService();
            var servicesDropDown = insuranceServices.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Name
            }).ToList();
            var homeModel = new IndexViewModel
            {
                Services = servicesDropDown,
                Lead = new Lead()
            };
            if (TempData.ContainsKey("error"))
            {
                homeModel.errorMessage = TempData["error"].ToString();
            }

            return View(homeModel);
        }
        
        [HttpPost]
        public IActionResult RedirectToService(Lead lead)
        {
            try
            {
                var service = lead.InsuranceServiceId;
                var zipCode = lead.ZipCode;
                var validateZipcode = _checkGeoLocationService.CheckGeoLocationZipCode(zipCode).Result;
                if (validateZipcode)
                {
                    HttpContext.Session.SetString("ZipCode", zipCode);
                    return service switch
                    {
                        1 => RedirectToAction("Index", "Health"),
                        2 => RedirectToAction("Index", "Medicare"),
                        3 => RedirectToAction("Index", "Auto"),
                        4 => RedirectToAction("Index", "Home"),
                        5 => RedirectToAction("Index", "Life"),
                        _ => RedirectToAction("Index", "Home")
                    };
                }
                TempData["error"] = "Invalid Zip Code";
                return RedirectToAction("index", "Home");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}