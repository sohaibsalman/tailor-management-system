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

        public List<Order> GetNewOrders()
        {
            return new OrderDAL().GetNewOrders();
        }

        public List<OrdersAssigned> GetCompletedOrders()
        {
            return new OrderDAL().GetCompletedOrders();
        }

        public int GetEarningsOfCompletedOrders()
        {
            return new OrderDAL().GetEarningsOfCompletedOrders();
        }

        public int GetEarningsOfPendingOrders()
        {
            return new OrderDAL().GetEarningsOfPendingOrders();
        }

        public List<OrdersAssigned> GetPendingOrders()
        {
            return new OrderDAL().GetPendingOrders();
        }

        public bool FinishOrder(int orderID)
        {
            return new OrderDAL().FinishOrder(orderID);
        }

        public List<Order> GetAllOrders()
        {
            return new OrderDAL().GetAllOrders();
        }

        public bool AssingToWorker(int customerID, int workerID, string orderName, int price, DateTime now)
        {
            return new OrderDAL().AssingToWorker(customerID, workerID, orderName, price, now);
        }
    }
}
