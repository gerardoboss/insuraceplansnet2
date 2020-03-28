using System.ComponentModel.DataAnnotations.Schema;

namespace InsurancePlansNetCoreData.Models
{
    [Table("auto_trim")]
    public class AutoTrim
    {
        public int Id { get; set; } 
        public string Trim { get; set; }
    }
}