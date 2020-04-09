using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;

namespace TMS.DAL
{
    public class WorkerDAL
    {
        public string AddWorker(Worker w)
        {
            String msg = "";
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);

            try
            {
                con.Open();

                String query = "INSERT INTO Workers VALUES (@name, @address, @number, @joiningdate, @salary)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", w.Name);
                cmd.Parameters.AddWithValue("@address", w.Address);
                cmd.Parameters.AddWithValue("@number", w.ContactNumber);
                cmd.Parameters.AddWithValue("@joiningdate", w.JoiningDate);
                cmd.Parameters.AddWithValue("@salary", w.Salary);

                int res = cmd.ExecuteNonQuery();
                if (res < 0)
                    msg = "error";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return msg;
        }
    }
}
