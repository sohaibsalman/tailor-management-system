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

namespace Windows.UI
{
    public partial class FormTotalEarnings : Form
    {
        public FormTotalEarnings()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTotalEarnings_Load(object sender, EventArgs e)
        {
            int completed, pending, salary;
            completed = pending = salary = -1;

            completed = new OrderBLL().GetEarningsOfCompletedOrders();
            pending = new OrderBLL().GetEarningsOfPendingOrders();
            salary = new WorkerBLL().GetSalaryOfWorkers();

            txtCompleted.Text = completed.ToString();
            txtPending.Text = pending.ToString();
            txtSalary.Text = salary.ToString();
        }
    }
}
