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

        public string[] GetFileNames()
        {
            string [] fileNames = Directory.GetFiles("Measurements/");
            return fileNames;
        }
    }
}
