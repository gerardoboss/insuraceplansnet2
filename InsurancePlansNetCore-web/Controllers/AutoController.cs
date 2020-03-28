using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using InsurancePlansNetCoreData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsurancePlansNetCore_web.Controllers
{
    public class AutoModel
    {
        [Required]
        public string CurrentlyInsure { get; set; }
        public string[] CurrenttlyInsuranceAnswers = {"Yes", "No"};
        [Required]
        public string OwnHome { get; set; }
        public string[] OwnHomeOptions = { "I own my home", "I own my condo", "I rent", "Other"};
        public Auto Auto { get; set; }
    }
    public class AutoController : Controller
    {
        // GET
        public IActionResult Index()
        {
            try
            {
                var autoModel = new AutoModel {Auto = new Auto()};
                return View(autoModel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public IActionResult Step2(string CurrentlyInsure, string OwnHome)
        {
            try
            {
                var autoInsuranceLead = new Auto {CurrentlyInsured = CurrentlyInsure == "Yes", OwnHome = OwnHome};
                var jsonAutoLead = JsonSerializer.Serialize(autoInsuranceLead);
                HttpContext.Session.SetString("autoLead", jsonAutoLead);
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        public IActionResult Step3(Auto autoLead)
        {
            try
            {
                var autoInsurnace = new Auto();
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}