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
    public class UserDAL
    {
        public List<User> GetAllUsers()
        {
            //CONNECT DB;
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);
            List<User> users = new List<User>();
            try
            {
                con.Open();
                String query = "select * from Users";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    User u = new User();
                    //init data members
                    u.ID = (int) reader["ID"];
                    u.Name = reader["Name"].ToString();
                    u.Username = reader["Username"].ToString();
                    u.Password = reader["Password"].ToString();
                    u.IsActive = Convert.ToBoolean(reader["IsActive"]);
                    u.IsAdmin = Convert.ToBoolean(reader["IsActive"]);
                    u.RegistrationDate = Convert.ToDateTime(reader["RegistrationDate"]);
                    u.LastLogin = Convert.ToDateTime(reader["LastLogin"]);
                    //add to list
                    users.Add(u);
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
            return users;
        }

        public string DeleteUser(int id)
        {
            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);

            try
            {
                con.Open();
                String query = "DELETE FROM Users WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                int res = cmd.ExecuteNonQuery();
                if (res < 0)
                    return "error";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return "";
        }

        public string CreateUser(User u)
        {
            String msg = "";

            SqlConnection con = new SqlConnection(HelperDB.ConnectionString);

            try
            {
                con.Open();
                String query = "INSERT INTO Users (Name, Username, Password, RegistrationDate, LastLogin, IsActive, IsAdmin) " +
                " VALUES (@name, @username, @password, @regdate, @lastlogin, @active, @admin)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", u.Name);
                cmd.Parameters.AddWithValue("@username", u.Username);
                cmd.Parameters.AddWithValue("@password", u.Password);
                cmd.Parameters.AddWithValue("@regdate", System.DateTime.Now);
                cmd.Parameters.AddWithValue("@lastlogin", System.DateTime.Now);
                cmd.Parameters.AddWithValue("@active", Convert.ToInt32(u.IsActive));
                cmd.Parameters.AddWithValue("@admin", Convert.ToInt32(u.IsAdmin));

                int result = cmd.ExecuteNonQuery();
                if (result < 0)
                    msg = "error";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            
            return msg;
        }
    }
}
