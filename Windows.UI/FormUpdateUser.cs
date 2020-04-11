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
    public partial class FormUpdateUser : Form
    {
        public static User updatedUser;
        public FormUpdateUser()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            new FormSearchUser().ShowDialog();
            if(updatedUser != null)
            {
                txtName.Text = updatedUser.Name;
                txtPassword.Text = updatedUser.Password;
                if (updatedUser.IsActive)
                    isActive.CheckState = CheckState.Checked;
                if(updatedUser.IsAdmin)
                    isAdmin.CheckState = CheckState.Checked;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                User u = updatedUser;

                u.Name = txtName.Text;
                u.Password = txtPassword.Text;
                u.IsActive = Convert.ToBoolean(isActive.CheckState);
                u.IsAdmin = Convert.ToBoolean(isAdmin.CheckState);

                String msg = new UserBLL().UpdateUser(u);
                if(msg.Trim() == "")
                {
                    MessageBox.Show("Data Updated Successfuly", "Success");
                }
                else
                {
                    MessageBox.Show("Unable to Update Data", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill all input fields of Form", "Error");
            }
        }
    }
}
