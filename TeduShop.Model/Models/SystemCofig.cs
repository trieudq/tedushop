using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Models
{
    public class SystemCofig
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Code { get; set; }
        public string ValueString { get; set; }
        public int ValueInt { get; set; }
    }
}
