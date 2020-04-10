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
    public partial class FormAddCustomer : Form
    {
        private static List<Dictionary<string, int>> list = new List<Dictionary<string, int>>();
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtAddress.Text = "";
            txtCNIC.Text = "";
            txtContactNumber.Text = "";
            txtName.Text = "";
            txtRemarks.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new FormMeasurements().ShowDialog();
            if(FormMeasurements.measurementName != "")
            {
                lstMeasurements.Items.Add(FormMeasurements.measurementName);
                list.Add(FormMeasurements.measurementValues);
            }

        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtCNIC.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtContactNumber.Text.Trim() == "")
            {
                MessageBox.Show("Please input all form fields!", "Error");
            }
            else if(lstMeasurements.Items.Count == 0)
            {
                MessageBox.Show("Please Add some measurements first!", "Error");
            }
            else
            {
                //Create new Customer object
                Customer c = new Customer();

                //Add data from form to object
                c.Name = txtName.Text;
                c.CNIC = txtCNIC.Text;
                c.ContactNumber = txtContactNumber.Text;
                c.Address = txtAddress.Text;
                c.Remarks = txtRemarks.Text;
                c.Order = list;

                //get data ordered item names
                List<String> orderName = new List<string>();

                for (int i = 0; i < lstMeasurements.Items.Count; i++)
                {
                    lstMeasurements.SetSelected(i, true);
                    string item = lstMeasurements.SelectedItem.ToString();
                    orderName.Add(item);
                }

                String msg = new CustomerBLL().AddCustomer(c, orderName);
                if (msg.Trim() == "")
                {
                    MessageBox.Show("Customer Added Successfully", "Success");
                }
                else
                    MessageBox.Show("Error Adding customer", "Error");
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int index = lstMeasurements.SelectedIndex;
            lstMeasurements.Items.RemoveAt(index);
        }
    }
}
