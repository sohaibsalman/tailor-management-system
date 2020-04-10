using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetWorkersStats(List<Worker> workerList)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);

            try
            {
                con.Open();

                dt.Columns.Add("Worker Name");
                dt.Columns.Add("Task Assigned");
                dt.Columns.Add("Completed Tasks");
                dt.Columns.Add("Pending Tasks");

                for (int i = 0; i < workerList.Count; i++)
                {
                    DataRow dr = dt.NewRow();

                    String query = "SELECT COUNT(*) FROM OrdersAssigned WHERE WorkerID = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", workerList.ElementAt(i).ID);
                    int tasks = (int) cmd.ExecuteScalar();


                    query = "SELECT COUNT(*) FROM OrdersAssigned WHERE WorkerID = @wid AND Status = 1";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@wid", workerList.ElementAt(i).ID);
                    int completed = (int)cmd.ExecuteScalar();

                    int pending = tasks - completed;

                    dr["Worker Name"] = workerList.ElementAt(i).Name;
                    dr["Task Assigned"] = tasks;
                    dr["Completed Tasks"] = completed;
                    dr["Pending Tasks"] = pending;

                    dt.Rows.Add(dr);
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

            return dt;
        }

        public List<Worker> GetAllWorkers()
        {
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
            List<Worker> list = new List<Worker>();
            try
            {
                con.Open();
                String query = "SELECT * FROM Workers";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Worker temp = new Worker();
                    temp.ID = (int)reader["ID"];
                    temp.Address = reader["Address"].ToString();
                    temp.ContactNumber = reader["ContactNumber"].ToString();
                    temp.JoiningDate = Convert.ToDateTime(reader["JoiningDate"]);
                    temp.Name = reader["Name"].ToString();
                    temp.Salary = (int)reader["Salary"];
                    list.Add(temp);
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
