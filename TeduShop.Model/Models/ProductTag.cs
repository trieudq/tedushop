using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int ProductID { get; set; }
        [Key]
        public string TagID { get; set; }

        [ForeignKey("ProcuctID")]
        public Product Product { get; set; }
        [ForeignKey("TagID")]
        public Tag Tag { get; set; }

    }
}
