using System.ComponentModel.DataAnnotations;

namespace InsurancePlans_Core
{
    public class Health
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Reason For Shopping")]
        public int HealthReasonId { get; set; }
        public virtual HealthReason Reason { get; set; }
        public bool BusinessOwner { get; set; }
        public int HealthPlanTermId { get; set; }
        public virtual HealthPlanTerm HealthPlanTerm{ get; set; }
        public Lead Information { get; set; }
    }
}