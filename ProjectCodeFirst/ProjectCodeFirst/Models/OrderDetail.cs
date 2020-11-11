using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCodeFirst.Models
{
    public class OrderDetail 
    {
        public  int ID { get; set; }

        public int QUANTITY { get; set; }

        [Column(TypeName = "money")]
        public decimal PRICE { get; set; }


        public Order Order { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

     

    }
}
