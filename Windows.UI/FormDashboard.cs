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
    public partial class FormDashboard : Form
    {
        public static String username;
        public static bool isAdmin;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCreateUser().ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddWorker().ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddCustomer().ShowDialog();
        }

        private void assignWorkToWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAssignWork().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().ShowDialog();
            this.Close();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            if(!isAdmin)
            {
                assignmentToolStripMenuItem.Visible = false;
                reportsToolStripMenuItem.Visible = false;
                createUserToolStripMenuItem.Visible = false;
            }

            deleteToolStripMenuItem.Enabled = false;

            lblUsername.Text = username;
            String customers = new CustomerBLL().GetAllCustomers().Count.ToString();
            String orders = new OrderBLL().GetAllOrders().Count.ToString();
            String workers = new WorkerBLL().GetAllWorkers().Count.ToString();
            if (customers.Length == 1)
                lblCustomers.Text = "0" + customers;
            else
                lblCustomers.Text = customers;
            if (orders.Length == 1)
                lblOrders.Text = "0" + orders;
            else
                lblOrders.Text = orders;
            if (workers.Length == 1)
                lblWorkers.Text = "0" + workers;
            else
                lblWorkers.Text = workers;

        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormUpdateWorker().ShowDialog();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormUpdateCustomer().ShowDialog();
        }

        private void userToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new FormUpdateUser().ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDeleteRecord().ShowDialog();
        }

        private void workerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormSearchCustomer().ShowDialog();
        }

        private void customerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new FormSearchWorker().ShowDialog();
        }

        private void userToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new FormSearchUser().ShowDialog();
        }

        private void checkWorkStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFinishOrder().ShowDialog();
        }

        private void pendingOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPendingOrders().ShowDialog();
        }

        private void ordersCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormOrdersCompleted().ShowDialog();
        }

        private void workersStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormWorkerStats().ShowDialog();
        }

        private void totalEarningsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormTotalEarnings().ShowDialog();
        }
    }
}
