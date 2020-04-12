using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.BLL;
using TMS.Common;

namespace Windows.UI
{
    public partial class FormWorkerStats : Form
    {
        public FormWorkerStats()
        {
            InitializeComponent();
        }

        private void FormWorkerStats_Load(object sender, EventArgs e)
        {
            List<Worker> workerList = new WorkerBLL().GetAllWorkers();
            DataTable table = new WorkerBLL().GetWorkersStats(workerList);
            tableData.DataSource = table;
        }
    }
}
