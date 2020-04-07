using System.ComponentModel.DataAnnotations;

namespace InsurancePlans_Core
{
    public class HealthPlanTerm
    {
        public int Id { get; set; }
        [Display(Name="Plan Term")]
        public string Name { get; set; }
    }
}