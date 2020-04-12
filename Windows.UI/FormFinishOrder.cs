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
    public partial class FormFinishOrder : Form
    {
        public FormFinishOrder()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFinishOrder_Load(object sender, EventArgs e)
        {
            List<OrdersAssigned> list = new OrderBLL().GetPendingOrders();
            tableData.DataSource = list;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<OrdersAssigned> list = new OrderBLL().GetPendingOrders();

            if (txtSearch.Text.Trim() != "")
            {
                var result = (from t in list where t.CustomerName.Contains(txtSearch.Text) select t).ToList<OrdersAssigned>();
                tableData.DataSource = result;
            }
            else
            {
                tableData.DataSource = list;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(tableData.Rows.Count > 0)
            {
                int index = tableData.CurrentCell.RowIndex;
                DataGridViewRow row = tableData.Rows[index];

                int orderID = (int) row.Cells[2].Value;

                bool state = new OrderBLL().FinishOrder(orderID);

                if(state)
                {
                    MessageBox.Show("Order Finished", "Success");
                    FormFinishOrder_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Error finishing the Order", "Error");
                }
            }
        }
    }
}
