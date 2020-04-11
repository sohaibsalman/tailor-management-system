using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
