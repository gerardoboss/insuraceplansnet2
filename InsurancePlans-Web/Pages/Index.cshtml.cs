using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using InsurancePlans_Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace InsurancePlans_Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //private GeoLocation GeoLocation { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$")]
        public string ZipCode { get; set; }
       

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}