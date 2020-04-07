using System.ComponentModel.DataAnnotations.Schema;

namespace InsurancePlans_Core
{
    [Table("auto_brand")]
    public class AutoBrand
    {
        public int Id { get; set; }
        public string Brand { get; set; }
    }
}