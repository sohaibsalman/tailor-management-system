using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Common
{
    public class Customer
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String CNIC { get; set; }
        public String ContactNumber { get; set; }
        public String Address { get; set; }
        public String Remarks { get; set; }
        public List<Dictionary<string, int>> Order { get; set; }
    }
}
