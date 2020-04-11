using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.UI
{
    public partial class FormDeleteRecord : Form
    {
        public FormDeleteRecord()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            FormDelete.deleteRecordType = cbxRecordType.SelectedValue.ToString();
            new FormDelete().ShowDialog();
        }

        private void FormDeleteRecord_Load(object sender, EventArgs e)
        {
            List<String> list = new List<string>();
            list.Add("Worker");
            list.Add("User");
            list.Add("Customer");

            cbxRecordType.DataSource = list;
        }
    }
}
