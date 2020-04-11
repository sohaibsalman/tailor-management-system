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
    public partial class FormDelete : Form
    {
        public static string deleteRecordType = "";
        public FormDelete()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            if(deleteRecordType.Trim().ToLower() == "worker")
            {
                List<Worker> workerList = new WorkerBLL().GetAllWorkers();
                tableData.DataSource = workerList;
            }
            else if(deleteRecordType.Trim().ToLower() == "user")
            {

            }
            else if(deleteRecordType.Trim().ToLower() == "customer")
            {

            }
        }
    }
}
