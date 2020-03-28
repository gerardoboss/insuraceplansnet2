using System.ComponentModel.DataAnnotations.Schema;

namespace InsurancePlansNetCoreData.Models
{
    [Table("auto_model")]
    public class AutoModel
    {
        public int Id { get; set; }
        public int Model { get; set; }
    }
}