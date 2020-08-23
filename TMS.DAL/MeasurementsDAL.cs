using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;

namespace TMS.DAL
{
    public class MeasurementsDAL
    {
        public void AddNewFile(List<string> data)
        {
            String fileName = data.ElementAt(0);

            using (StreamWriter file = new StreamWriter("Measurements/" + fileName + ".txt", true))
            {
                for (int i = 1; i < data.Count; i++)
                {
                    file.WriteLine(data.ElementAt(i));
                }
                file.Close();
            }
        }



        public string[] GetFileNamesWeb(string path)
        {
            string[] fileNames = Directory.GetFiles(path);
            return fileNames;
        }

        public DataTable GetMeasurementsFromFile(string name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Measurements Name");

            using (StreamReader file = new StreamReader("Measurements/" + name + ".txt"))
            {
                while (!file.EndOfStream)
                {
                    DataRow dr = dt.NewRow();
                    dr["Measurements Name"] = file.ReadLine();
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        public void AddNewFile(List<string> data, string ph_path)
        {
            using (StreamWriter file = new StreamWriter(ph_path + ".txt", true))
            {
                for (int i = 0; i < data.Count; i++)
                {
                    file.WriteLine(data.ElementAt(i));
                }
                file.Close();
            }
        }

        public bool InsertMeasurements(Customer c, List<string> orderName)
        {
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
            try
            {
                con.Open();

                int id = c.ID;
                String query;
                int res;
                for (int i = 0; i < orderName.Count; i++)
                {
                    string tableName = orderName.ElementAt(i).Trim().ToUpper();
                    Dictionary<String, int> d = c.Order.ElementAt(i);

                    List<string> colName = new List<string>(d.Keys);
                    List<int> colValue = new List<int>(d.Values);

                    query = "INSERT INTO Measurement_" + tableName + " ( Name, CustomerID, ";
                    //GET COLUMN NAMES
                    for (int j = 0; j < colName.Count; j++)
                    {
                        query += colName.ElementAt(j);
                        if (j != colName.Count - 1)
                            query += ", ";
                    }
                    query += ") VALUES ('" + tableName.ToLower() + "', " + id.ToString() + ", ";
                    //GET COLUMN VALUES
                    for (int j = 0; j < colValue.Count; j++)
                    {
                        query += colValue.ElementAt(j);
                        if (j != colValue.Count - 1)
                            query += ", ";
                    }

                    query += ")";

                    SqlCommand cmd = new SqlCommand(query, con);
                    res = cmd.ExecuteNonQuery();

                    if (res < 0)
                        return false;


                    Order o = new Order();
                    o.CustomerID = id;
                    o.OrderName = orderName.ElementAt(i).Trim();
                    o.Status = false;

                    new OrderDAL().AddNewOrder(o);
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
            return true;
        }

        public DataTable GetMeasurementsFromFileWeb(string name)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Measurements Name");
            dt.Columns.Add("Measurements Value");

            using (StreamReader file = new StreamReader(name))
            {
                while (!file.EndOfStream)
                {
                    DataRow dr = dt.NewRow();
                    dr["Measurements Name"] = file.ReadLine();
                    dr["Measurements Value"] = "0";
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        public void CreateNewType(List<string> fileData)
        {
            try
            {
                SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
                con.Open();

                String tableName = fileData.ElementAt(0).Trim().ToUpper();

                //Create a new table
                String query = "CREATE TABLE Measurement_" + tableName + " ( Name varchar(100), CustomerID int )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                int columns = fileData.Count;

                for (int i = 1; i < columns; i++)
                {
                    String colName = fileData.ElementAt(i);
                    query = "ALTER TABLE Measurement_" + tableName + " ADD " + colName + " int";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CreateNewType(List<string> fileData, string fileName)
        {
            try
            {
                SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
                con.Open();

                String tableName = fileName.ToUpper();

                //Create a new table
                String query = "CREATE TABLE Measurement_" + tableName + " ( Name varchar(100), CustomerID int )";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                int columns = fileData.Count;

                for (int i = 0; i < columns; i++)
                {
                    String colName = fileData.ElementAt(i);
                    query = "ALTER TABLE Measurement_" + tableName + " ADD " + colName + " int";
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string[] GetFileNames(bool flag = false)
        {
            string [] fileNames = Directory.GetFiles("Measurements/");
            return fileNames;
        }
    }
}
