using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;
using TMS.DAL;

namespace TMS.BLL
{
    public class UserBLL
    {
        public List<User> GetAllUsers()
        {
            return new UserDAL().GetAllUsers();
        }

        public string CreateUser(User user)
        {
            return new UserDAL().CreateUser(user);
        }

        public string DeleteUser(int id)
        {
            return new UserDAL().DeleteUser(id);
        }

        public string UpdateUser(User u)
        {
            return new UserDAL().UpdateUser(u);
        }
    }
}
