using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorWshop.Models
{
    public class CartItem
    {
        public List<KeyValuePair<int, int>> item { get; set; }
        public CartItem()
        {
            item = new List<KeyValuePair<int, int>>();
        }
    }
}
