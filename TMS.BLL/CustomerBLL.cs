using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;
using TMS.DAL;

namespace TMS.BLL
{
    public class CustomerBLL
    {
        public string AddCustomer(Customer c, List<string> orders)
        {
            return new CustomerDAL().AddCustomer(c, orders);
        }

        public List<Customer> GetAllCustomers()
        {
            return new CustomerDAL().GellAllCustomers();
        }

        public string DeleteCustomer(int id)
        {
            return new CustomerDAL().DeleteCustomer(id);
        }

        public bool UpdateCustomer(Customer c)
        {
            return new CustomerDAL().UpdateCustomer(c);
        }
    }
}
