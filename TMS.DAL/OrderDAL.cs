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

        public string AssingToWorker(Customer selectedCustomer, Worker selectedWorker, string orderName)
        {
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);

            try
            {
                con.Open();

                String query = "SELECT ID FROM Orders WHERE CustomerID = @cid AND OrderName = @ordername AND STATUS = 0";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cid", selectedCustomer.ID);
                cmd.Parameters.AddWithValue("@ordername", selectedWorker.Name);

                int id = (int)cmd.ExecuteScalar();

                query = "INSERT INTO OrdersAssigned (WorkerID, CustomerID, OrderID, Status) VALUES (@wid, @cusid, @oid, 1)";
                cmd.Parameters.AddWithValue("@wid", selectedWorker.ID);
                cmd.Parameters.AddWithValue("@cusid", selectedCustomer.ID);
                cmd.Parameters.AddWithValue("@oid", id);

                int res = cmd.ExecuteNonQuery();
                if (res < 0)
                    return "error";

                query = "UPDATE Orders SET Status = 1 WHERE OrderID = " + id;
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

            return list;
        }
    }
}
