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

        public List<string> GetTypeOfMeasurement(int id)
        {
            List<String> list = new List<string>();
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
            try
            {
                con.Open();
                String query = "SELECT * FROM Orders WHERE ID = " + id;
                SqlCommand cmd = new SqlCommand(query, con);


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
