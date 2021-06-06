using System;
using System.ComponentModel.DataAnnotations;
using RazorWshop.Models;

namespace RazorWshop.Entity
{
    public class OrderDetail
    {

        [Required]
        public int SerialNo { get; set; }

        [MaxLength(20)]
        [Required]
        public string ActivationCode { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        public virtual Product Products { get; set; }
        public virtual User Users { get; set; }
    }
}
