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
    public partial class FormSearchWorker : Form
    {
        List<Worker> workerList = new WorkerBLL().GetAllWorkers();
        public FormSearchWorker()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSearchWorker_Load(object sender, EventArgs e)
        {
            tableSearchRecord.DataSource = workerList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim() == "")
            {
                tableSearchRecord.DataSource = workerList;
            }
            else
            {
                var result = (from t in workerList where t.Name.Contains(txtSearch.Text.Trim()) select t).ToList<Worker>();
                tableSearchRecord.DataSource = result;
            }
        }

        private void tableSearchRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = tableSearchRecord.CurrentCell.RowIndex;

            if(index >= 0)
            {
                DataGridViewRow row = tableSearchRecord.Rows[index];

                Worker w = new Worker();
                w.ID = (int)row.Cells[0].Value;
                w.Name = row.Cells[1].Value.ToString();
                w.Address = row.Cells[2].Value.ToString();
                w.ContactNumber = row.Cells[3].Value.ToString();
                w.JoiningDate = Convert.ToDateTime(row.Cells[4].Value);
                w.Salary = (int)row.Cells[5].Value;

                FormUpdateWorker.updatedValue = w;
                this.Close();
            }
        }
    }
}
