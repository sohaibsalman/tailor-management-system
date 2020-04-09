using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Common
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public String OrderName { get; set; }
        public bool Status { get; set; }
    }
}
