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
    public partial class FormAddWorker : Form
    {
        public FormAddWorker()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtAddress.Text = "";
            txtContactNumber.Text = "";
            txtName.Text = "";
            txtSalary.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();

            w.Name = txtName.Text;
            w.ContactNumber = txtContactNumber.Text;
            w.Address = txtAddress.Text;
            w.JoiningDate = dtDateOfJoining.Value;
            w.Salary = Convert.ToInt32(txtSalary.Text);

            String msg = new WorkerBLL().AddWoker(w);

            if(msg.Trim() == "")
            {
                MessageBox.Show("Worker Added!", "Success");
                ClearForm();
            }
            else
                MessageBox.Show("Error Adding Worker", "Error");

        }
    }
}
