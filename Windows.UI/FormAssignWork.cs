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
    public partial class FormAssignWork : Form
    {
        public FormAssignWork()
        {
            InitializeComponent();
        }

        private void FormAssignWork_Load(object sender, EventArgs e)
        {
            List<Customer> customerList = new CustomerBLL().GetAllCustomers();
            cbxCustomer.DataSource = customerList;
            cbxCustomer.DisplayMember = "Name";            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = (Customer) cbxCustomer.SelectedValue;
            List<String> list = new OrderBLL().GetTypeOfMeasurement(c.ID);

            cbxMeasurement.DataSource = list;
            cbxMeasurement.DisplayMember = "OrderName";
        }
    }
}
