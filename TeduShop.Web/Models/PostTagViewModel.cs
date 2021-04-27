﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeduShop.Web.Models
{
    public class PostTagViewModel
    {
        public int PostID { get; set; }
       
        public string TagID { get; set; }
        
        public PostViewModel Post { get; set; }
        
        public TagViewModel Tag { get; set; }
    }
}