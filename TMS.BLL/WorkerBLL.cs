using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;
using TMS.DAL;

namespace TMS.BLL
{
    public class WorkerBLL
    {
        public string AddWoker(Worker w)
        {
            return new WorkerDAL().AddWorker(w);
        }
    }
}
