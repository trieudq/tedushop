﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TeduShop.Model.Abtract;

namespace TeduShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        public string Description { get; set; }
        public int? ParentID { get; set; }
        public int? DesplayOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public bool Status { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
