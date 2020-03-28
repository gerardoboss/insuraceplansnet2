using System;
using System.ComponentModel.DataAnnotations;
using InsurnacePlansNetCore_data.Models;

namespace InsurancePlansNetCoreData.Models
{
    public class Auto
    {
        public int Id { get; set; }
        [Required]
        public int Year { get; set; }
        public int ModelId  { get; set; }
        public virtual AutoModel Model { get; set; }
        public int BrandId { get; set; }
        public virtual AutoBrand Brand{ get; set; }
        public int TrimId { get; set; }
        public virtual AutoTrim Trim{ get; set; }
        [Display(Name="Own or Lease")]
        public bool OwnLease { get; set; }
        public int Use { get; set; }
        [Display(Name="Estimated Miles")]
        public int EstimatedMiles { get; set; }
        public int Frequency { get; set; }
        [Display(Name="Currently Insured")]
        public bool CurrentlyInsured { get; set; }
        [Display(Name="Insurnace Company")]
        public string InsuranceCompany { get; set; }
        [Display(Name="Accidents in the last 3 years")]
        public bool Accidents3Years { get; set; }
        public int LeadId { get; set; }
        public virtual Lead Lead{ get; set; }
        public string OwnHome { get; set; }
    }
}

