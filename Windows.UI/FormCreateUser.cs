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
    public partial class FormCreateUser : Form
    {
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            cbxAccountType.SelectedIndex = 0;
            chkActive.CheckState = CheckState.Checked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Please Fill all the form inputs!", "Error");
            }
            else
            {
                User user = new User();
                //init user object
                user.Name = txtName.Text;
                user.Password = txtPassword.Text.Trim();
                user.Username = txtUsername.Text.Trim();
                if (cbxAccountType.SelectedItem.ToString() == "Admin")
                    user.IsAdmin = true;
                else
                    user.IsAdmin = false;
                if (chkActive.CheckState == CheckState.Checked)
                    user.IsActive = true;
                else
                    user.IsActive = false;
                //Call BLL Function to add user
                String msg = new UserBLL().CreateUser(user);
                if (msg.Trim() == "")
                {
                    MessageBox.Show("User Created!", "Success");
                    ClearForm();
                }
                else
                    MessageBox.Show("Error Adding User!", "Error");
            }
        }

        private void FormCreateUser_Load(object sender, EventArgs e)
        {
            List<String> accountTypes = new List<string>();
            accountTypes.Add("Operator");
            accountTypes.Add("Admin");

            cbxAccountType.DataSource = accountTypes;
        }
    }
}
