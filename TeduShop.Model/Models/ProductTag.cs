using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(Order=1)]
        public int ProductID { get; set; }
        [Key]
        [Column(Order = 2)]
        public string TagID { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        [ForeignKey("TagID")]
        public Tag Tag { get; set; }

    }
}
