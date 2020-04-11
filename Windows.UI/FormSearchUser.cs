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

        private void tableSearchRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = tableSearchRecord.CurrentCell.RowIndex;
            if(index >= 0)
            {
                User u = new User();
                DataGridViewRow row = tableSearchRecord.Rows[index];

                u.ID = (int)row.Cells[0].Value;
                u.Name = row.Cells[1].Value.ToString();
                u.Username = row.Cells[2].Value.ToString();
                u.Password = row.Cells[3].Value.ToString();
                u.RegistrationDate = Convert.ToDateTime(row.Cells[4].Value.ToString());
                u.LastLogin = Convert.ToDateTime(row.Cells[5].Value.ToString());
                u.IsActive = Convert.ToBoolean(row.Cells[6].Value.ToString());
                u.IsAdmin = Convert.ToBoolean(row.Cells[7].Value.ToString());

                FormUpdateUser.updatedUser = u;
                this.Close();
            }
        }
    }
}
