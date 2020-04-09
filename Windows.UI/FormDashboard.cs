using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.UI
{
    public partial class FormDashboard : Form
    {
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
    }
}
