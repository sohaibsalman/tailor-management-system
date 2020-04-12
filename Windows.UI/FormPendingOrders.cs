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
    public partial class FormPendingOrders : Form
    {
        public FormPendingOrders()
        {
            InitializeComponent();
        }

        private void FormPendingOrders_Load(object sender, EventArgs e)
        {
            List<OrdersAssigned> orders = new OrderBLL().GetPendingOrders();
            tableData.DataSource = orders;
        }
    }
}
