using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeduShop.Model.Abtract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreateDate { get; set;}
        [MaxLength(256)]
        public string CreateBy { get ; set;}
        public DateTime? UpdatedDate { get; set;}
        [MaxLength(256)]
        public string UpdatedBy { get ; set;}
        [MaxLength(256)]
        public string MetaKeyword { get; set;}
        [MaxLength(256)]
        public string MetaDescription { get ; set;}
        public bool Status { get ; set;}
    }
}
