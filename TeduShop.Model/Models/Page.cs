using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    public class Page
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Content { get; set; }
        public string MetaDescription { get; set; }
        public string MeteKeyword { get; set; }
        public bool Status { get; set; }
    }
}
