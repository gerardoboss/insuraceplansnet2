using System.ComponentModel.DataAnnotations;
using InsurnacePlansNetCore_data.Models;

namespace InsurancePlansNetCoreData.Models
{
    public class Health
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Reason For Shopping")]
        public int HealthReasonId { get; set; }
        public virtual HealthReason Resson { get; set; }
        public bool BusinessOwner { get; set; }
        public int HealthPlanTermId { get; set; }
        public virtual HealthPlanTerm HealthPlanTerm{ get; set; }
        public Lead Information { get; set; }

    }
}