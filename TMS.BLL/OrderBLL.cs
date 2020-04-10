using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;
using TMS.DAL;

namespace TMS.BLL
{
    public class OrderBLL
    {
        public List<string> GetTypeOfMeasurement(int ID)
        {
            return new OrderDAL().GetTypeOfMeasurement(ID);
        }

        public string AssingToWorker(Customer selectedCustomer, Worker selectedWorker, string orderName, int price, DateTime date)
        {
            return new OrderDAL().AssingToWorker(selectedCustomer, selectedWorker, orderName, price, date);
        }
    }
}
