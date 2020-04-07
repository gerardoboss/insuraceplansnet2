using System.ComponentModel.DataAnnotations;

namespace InsurancePlans_Core
{
    public class GeoLocation
    {
        [Required]
        [Display(Name="Address")]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$")]
        public string ZipCode { get; set; }
    }
}