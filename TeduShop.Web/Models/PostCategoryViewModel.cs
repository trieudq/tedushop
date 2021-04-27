﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeduShop.Model.Models;

namespace TeduShop.Web.Models
{
    public class PostCategoryViewModel
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string Alias { get; set; }
        public string Description { get; set; }
        public int? ParentID { get; set; }
        public int? DesplayOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public bool Status { get; set; }
        public virtual IEnumerable<PostViewModel> Posts { get; set; }
    }
}