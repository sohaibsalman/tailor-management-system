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
    public partial class FormOrdersCompleted : Form
    {
        public FormOrdersCompleted()
        {
            InitializeComponent();
        }

        private void FormOrdersCompleted_Load(object sender, EventArgs e)
        {
            List<OrdersAssigned> list = new OrderBLL().GetCompletedOrders();
            tableData.DataSource = list;
        }
    }
}
