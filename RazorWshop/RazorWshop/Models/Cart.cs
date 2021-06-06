
using RazorWshop.Models;
using System.ComponentModel.DataAnnotations;

namespace CA_practice.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public virtual Product product { get; set; }

    }
}


