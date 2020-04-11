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
    public partial class FormUpdateWorker : Form
    {
        public static Worker updatedValue;
        public FormUpdateWorker()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new FormSearchWorker().ShowDialog();

            if(updatedValue != null)
            {
                txtFullName.Text = updatedValue.Name;
                txtAddress.Text = updatedValue.Address;
                txtContacNumber.Text = updatedValue.ContactNumber;
                txtSalary.Text = updatedValue.Salary.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() != "" && txtContacNumber.Text.Trim() != "" && txtFullName.Text.Trim() != "" && txtSalary.Text.Trim() != "")
            {
                Worker w = updatedValue;

                w.Name = txtFullName.Text;
                w.ContactNumber = txtContacNumber.Text;
                w.Address = txtAddress.Text;
                w.Salary = Convert.ToInt32(txtSalary.Text);

                bool state = new WorkerBLL().UpdateWorker(w);
                if(state)
                {
                    MessageBox.Show("Worker Data Updated Successfuly", "Success");
                }
                else
                {
                    MessageBox.Show("Error Updating Worker Data", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill all form input fields", "Error");
            }
        }
    }
}
