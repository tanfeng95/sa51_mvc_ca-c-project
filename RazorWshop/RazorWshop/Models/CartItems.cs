using CA_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorWshop.Models
{
    public class CartItems
    {
        public Dictionary<string, CartItem> map { get; set; }

        public CartItems()
        {
            map = new Dictionary<string, CartItem>();
        }
    }
}
