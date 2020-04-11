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
    public partial class FormDelete : Form
    {
        public static string deleteRecordType = "";
        public FormDelete()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            if(deleteRecordType.Trim().ToLower() == "worker")
            {
                List<Worker> workerList = new WorkerBLL().GetAllWorkers();
                tableData.DataSource = workerList;
            }
            else if(deleteRecordType.Trim().ToLower() == "user")
            {
                List<User> userList = new UserBLL().GetAllUsers();
                tableData.DataSource = userList;
            }
            else if(deleteRecordType.Trim().ToLower() == "customer")
            {
                List<Customer> customerList = new CustomerBLL().GetAllCustomers();
                tableData.DataSource = customerList;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRow = tableData.CurrentCell.RowIndex;
            String msg = "";

            int id;
            DataGridViewRow row = tableData.Rows[selectedRow];
            id = (int)row.Cells[0].Value;

            if (deleteRecordType.Trim().ToLower() == "worker")
            {
                msg = new WorkerBLL().DeleteWorker(id);
            }
            else if (deleteRecordType.Trim().ToLower() == "user")
            {
                msg = new UserBLL().DeleteUser(id);
            }
            else if (deleteRecordType.Trim().ToLower() == "customer")
            {
                
            }

            if(msg.Trim().ToLower() == "error")
            {
                MessageBox.Show("Error Deleting Selected Data", "Error");
            }
            else
            {
                MessageBox.Show("Data Deleted Succussfuly", "Success");
            }
            FormDelete_Load(sender, e);
        }
    }
}
