using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCodeFirst.Models
{
    public class Order
    {
        public int ID { get; set; }

        public int? CUSTOMER_ID { get; set; }

        [StringLength(200)]
        public string SHIP_NAME { get; set; }

        [StringLength(10)]
        public string SHIP_SDT { get; set; }

        [StringLength(200)]
        public string SHIP_EMAIL { get; set; }

        [StringLength(200)]
        public string SHIP_ADDRESS { get; set; }

        public DateTime CREATE_DATE { get; set; }

        public int? STATUS { get; set; }    

        public virtual List<OrderDetail> ORDER_DETAILS { get; set; }

    }
}
