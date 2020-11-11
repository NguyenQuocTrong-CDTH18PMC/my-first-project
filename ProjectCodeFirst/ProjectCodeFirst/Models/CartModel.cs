using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCodeFirst.Models
{
    public class CartModel
    {
        public Product product { get; set; }
        public int quantity { get; set; }
    }
}
