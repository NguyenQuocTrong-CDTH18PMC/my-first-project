using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCodeFirst.Models
{
    public class Account
    {
        public int ID { get; set; }

        public string EMAIL { get; set; }

        public string PASSWORD { get; set; }

        public int STATUS { get; set; }
    }
}
