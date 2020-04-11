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
    public partial class FormUpdateCustomer : Form
    {
        public static Customer updatedCustomer;
        public FormUpdateCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new FormSearchCustomer().ShowDialog();

            if(updatedCustomer != null)
            {
                txtFullName.Text = updatedCustomer.Name;
                txtCNIC.Text = updatedCustomer.CNIC;
                txtContactNumber.Text = updatedCustomer.ContactNumber;
                txtAddress.Text = updatedCustomer.Address;
            }
        }
    }
}
