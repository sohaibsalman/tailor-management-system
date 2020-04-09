using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Worker> GetAllWorkers()
        {
            return new WorkerDAL().GetAllWorkers();
        }

        public DataTable GetWorkersStats(List<Worker> workerList)
        {
            return new WorkerDAL().GetWorkersStats(workerList);
        }
    }
}
