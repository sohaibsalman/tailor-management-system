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
    public partial class FormLogin : Form
    {
        public static String username = "";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            List<User> users = new UserBLL().GetAllUsers();
            cbxUsername.DataSource = users;
            cbxUsername.DisplayMember = "Username";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbxUsername.SelectedIndex == -1)
                MessageBox.Show("Please Select User First", "Error");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Incorrect Password", "Error");
            else
            {
                User user = (User)cbxUsername.SelectedItem;
                if (user.Password == txtPassword.Text)
                {
                    this.Hide();
                    User u = (User)cbxUsername.SelectedValue;
                    FormDashboard.username = u.Username;
                    FormDashboard.isAdmin = u.IsAdmin;
                    new FormDashboard().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Password", "Error");
                }
            }
        }
    }
}
