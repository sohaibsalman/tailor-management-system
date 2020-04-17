using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;

namespace TMS.DAL
{
    public class OrderDAL
    {
        public void AddNewOrder(Order o)
        {
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
            try
            {
                con.Open();

                String query = ("INSERT INTO [Orders] (CustomerID, OrderName, Status) VALUES (@cid, @ordername, @status)");
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@cid", o.CustomerID);
                cmd.Parameters.AddWithValue("@ordername", o.OrderName);
                cmd.Parameters.AddWithValue("@status", 0);

                int res =  cmd.ExecuteNonQuery();          

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public int GetEarningsOfPendingOrders()
        {
            int sum = -1;

            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);

            try
            {
                con.Open();
                String query = "SELECT SUM(Price) FROM OrdersAssigned WHERE Status = 0";
                SqlCommand cmd = new SqlCommand(query, con);

                sum = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return sum;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> list = new List<Order>();
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);

            try
            {
                con.Open();
                String query = "SELECT * FROM Orders";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Order o = new Order();
                    o.CustomerID = (int)reader["CustomerID"];
                    o.ID = (int)reader["ID"];
                    o.OrderName = reader["OrderName"].ToString();
                    o.Status = Convert.ToBoolean(reader["Status"]);

                    list.Add(o);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public int GetEarningsOfCompletedOrders()
        {
            int sum = -1;

            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);

            try
            {
                con.Open();
                String query = "SELECT SUM(Price) FROM OrdersAssigned WHERE Status = 1";
                SqlCommand cmd = new SqlCommand(query, con);

                sum = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return sum;
        }

        public List<OrdersAssigned> GetCompletedOrders()
        {
            List<OrdersAssigned> list = new List<OrdersAssigned>();

            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM OrdersAssigned WHERE Status = 1";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    OrdersAssigned temp = new OrdersAssigned();
                    temp.CustomerID = (int)reader["CustomerID"];
                    temp.OrderID = (int)reader["OrderID"];

                    list.Add(temp);
                }
                reader.Close();

                for (int i = 0; i < list.Count; i++)
                {
                    query = "SELECT Name FROM Customers WHERE ID = @cid";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@cid", list.ElementAt(i).CustomerID);
                    String CustomerName = cmd1.ExecuteScalar().ToString();
                    list.ElementAt(i).CustomerName = CustomerName;
                }
                for (int i = 0; i < list.Count; i++)
                {
                    query = "SELECT OrderName FROM Orders WHERE ID = @oid";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    cmd2.Parameters.AddWithValue("@oid", list.ElementAt(i).OrderID);
                    String OrderName = cmd2.ExecuteScalar().ToString();
                    list.ElementAt(i).OrderName = OrderName;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }

            return list;
        }

        public bool FinishOrder(int orderID)
        {
            bool flag = true;
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
            try
            {
                con.Open();
                String query = "UPDATE OrdersAssigned SET Status = 1 WHERE OrderID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", orderID);

                int res = cmd.ExecuteNonQuery();
                if (res < 0)
                    flag = false;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return flag;
        }

        public List<OrdersAssigned> GetPendingOrders()
        {
            List<OrdersAssigned> list = new List<OrdersAssigned>();

            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM OrdersAssigned WHERE Status = 0";

                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    OrdersAssigned temp = new OrdersAssigned();
                    temp.CustomerID = (int)reader["CustomerID"];
                    temp.OrderID = (int)reader["OrderID"];

                    list.Add(temp);
                }
                reader.Close();

                for (int i = 0; i < list.Count; i++)
                {
                    query = "SELECT Name FROM Customers WHERE ID = @cid";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    cmd1.Parameters.AddWithValue("@cid", list.ElementAt(i).CustomerID);
                    String CustomerName = cmd1.ExecuteScalar().ToString();
                    list.ElementAt(i).CustomerName = CustomerName;
                }
                for (int i = 0; i < list.Count; i++)
                {
                    query = "SELECT OrderName FROM Orders WHERE ID = @oid";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    cmd2.Parameters.AddWithValue("@oid", list.ElementAt(i).OrderID);
                    String OrderName = cmd2.ExecuteScalar().ToString();
                    list.ElementAt(i).OrderName = OrderName;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }

            return list;
        }

        public string AssingToWorker(Customer selectedCustomer, Worker selectedWorker, string orderName, int price, DateTime date)
        {
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);

            try
            {
                con.Open();

                String query = "SELECT ID FROM Orders WHERE CustomerID = @cid AND OrderName = @ordername AND STATUS = 0";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cid", selectedCustomer.ID);
                cmd.Parameters.AddWithValue("@ordername", orderName);

                int id = (int)cmd.ExecuteScalar();

                query = "INSERT INTO [OrdersAssigned] (WorkerID, CustomerID, OrderID, Price, DateOfAssignment, Status) VALUES (@wid, @cusid, @oid, @price, @date, @status)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@wid", selectedWorker.ID);
                cmd.Parameters.AddWithValue("@cusid", selectedCustomer.ID);
                cmd.Parameters.AddWithValue("@oid", id);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@status", 0);

                int res = cmd.ExecuteNonQuery();
                if (res < 0)
                    return "error";

                query = "UPDATE Orders SET Status = 1 WHERE ID = " + id;
                cmd = new SqlCommand(query, con);
            
                res = cmd.ExecuteNonQuery();
                if (res < 0)
                    return "error";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return "";
        }

        public List<string> GetTypeOfMeasurement(int id)
        {
            List<String> list = new List<string>();
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Orders WHERE CustomerID = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    String name = reader["OrderName"].ToString();
                    list.Add(name);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return list;
        }
    }
}
