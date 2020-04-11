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
    public partial class FormSearchCustomer : Form
    {
        List<Customer> customerList = new CustomerBLL().GetAllCustomers();
        public FormSearchCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSearchCustomer_Load(object sender, EventArgs e)
        {
            tableSearchRecord.DataSource = customerList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                tableSearchRecord.DataSource = customerList;
            }
            else
            {
                var result = (from t in customerList where t.Name.Contains(txtSearch.Text.Trim()) select t).ToList<Customer>();
                tableSearchRecord.DataSource = result;
            }
        }

        private void tableSearchRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Customer c = new Customer();
            int index = tableSearchRecord.CurrentCell.RowIndex;

            if (index >= 0) 
            {
                DataGridViewRow row = tableSearchRecord.Rows[index];

                c.ID =(int) row.Cells[0].Value;
                c.Name = row.Cells[1].Value.ToString();
                c.CNIC = row.Cells[2].Value.ToString();
                c.ContactNumber = row.Cells[3].Value.ToString();
                c.Address = row.Cells[4].Value.ToString();
                c.Remarks = row.Cells[5].Value.ToString();

                FormUpdateCustomer.updatedCustomer = c;
                this.Close();
            }
        }
    }
}
