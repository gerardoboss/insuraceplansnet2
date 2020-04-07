using System.ComponentModel.DataAnnotations.Schema;

namespace InsurancePlans_Core
{
    [Table("auto_model")]
    public class AutoModel
    {
        public int Id { get; set; }
        public int Model { get; set; }
    }
}