using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DAL;

namespace TMS.BLL
{
    public class OrderBLL
    {
        public List<string> GetTypeOfMeasurement(int ID)
        {
            return new OrderDAL().GetTypeOfMeasurement(ID);
        }
    }
}
