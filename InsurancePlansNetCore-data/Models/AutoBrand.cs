using System.ComponentModel.DataAnnotations.Schema;

namespace InsurancePlansNetCoreData.Models
{
    [Table("auto_brand")]
    public class AutoBrand
    {
        public int Id { get; set; }
        public string Brand { get; set; }
    }
}