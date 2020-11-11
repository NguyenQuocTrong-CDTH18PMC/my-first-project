using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCodeFirst.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string NAME { get; set; }

        public double? PRICE { get; set; }

        public string IMAGE { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DATE { get; set; }

        public int STATUS { get; set; }

        public int GROUP_PRODUCT { get; set; }

        
        public virtual List<OrderDetail> ORDER_DETAILS { get; set; }


    }
}
