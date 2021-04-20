using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostTag")]
    public class PostTag
    {
        [Key]

        public int PostID { get; set; }
        [Key]
        public string TagID { get; set; }
        [ForeignKey("PostID")]
        public Post Post { get; set; }
        [ForeignKey("TagID")]
        public Tag Tag { get; set; }

    }
}
