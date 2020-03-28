using System.ComponentModel.DataAnnotations;

namespace InsurancePlansNetCoreData.Models
{
    public class Status
    {
        public int Id { get; set; }
        [Display(Name="Person Status")]
        public string name { get; set; }
    }
}