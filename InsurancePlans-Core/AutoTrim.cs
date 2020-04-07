using System.ComponentModel.DataAnnotations.Schema;

namespace InsurancePlans_Core
{
    [Table("auto_trim")]
    public class AutoTrim
    {
        public int Id { get; set; } 
        public string Trim { get; set; }
    }
}