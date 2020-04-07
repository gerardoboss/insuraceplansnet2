using System;
using System.ComponentModel.DataAnnotations;

namespace InsurancePlans_Core
{
    public class Lead
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name="Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }
        [Required]
        [Display(Name="Date of birthday")]
        public DateTime Dob { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name="Email Address")]
        public string Email { get; set; }
        [Required]
        [Phone]
        [Display(Name="Phone")]
        public string Phone { get; set; }
        [Phone]
        [Display(Name="Cell Phone")]
        public string CellPhone { get; set; }
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
        [Display(Name="Household")]
        public int Household { get; set; }
        [Required]
        [Display(Name="Household Income")]
        [Range(0, 99999999.99)]
        public decimal HouseholdIncome { get; set; }
        [Required]
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }
        [Required]
        [Display(Name="Tobacco Use")]
        public bool TobaccoUse { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status{ get; set; }
        [Required]
        [Display(Name = "Zip Code")]
        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$")]
        public string ZipCode { get; set; }
        [Required]
        public int InsuranceServiceId { get; set; }
        public virtual InsuranceService InsuranceService{ get; set; }
    }
}