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
    public partial class FormSearchUser : Form
    {
        List<User> userList = new UserBLL().GetAllUsers();

        public FormSearchUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
       {
            if(txtSearchUser.Text.Trim() == "")
            {
                tableSearchRecord.DataSource = userList;
            }
            else
            {
                var result = (from t in userList where t.Name.Contains(txtSearchUser.Text.Trim()) select t).ToList<User>();
                tableSearchRecord.DataSource = result;
            }
        }

        private void FormSearchUser_Load(object sender, EventArgs e)
        {
            tableSearchRecord.DataSource = userList;
        }
    }
}
