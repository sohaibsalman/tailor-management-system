using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Common
{
    public class User
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
    }
}
