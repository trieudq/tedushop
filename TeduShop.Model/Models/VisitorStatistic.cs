using System;
using System.ComponentModel.DataAnnotations;


namespace TeduShop.Model.Models
{
    public class VisitorStatistic
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }
        [Required]
        public string IPAddress { get; set; } 
    }
}
