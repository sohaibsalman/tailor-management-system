using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.BLL;
using TMS.Common;

namespace Web.UI
{
    public partial class FormAddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            User u = new User();

            u.Name = txtName.Text;
            u.Password = txtPassword.Text;
            u.Username = txtUsername.Text;
            u.RegistrationDate = System.DateTime.Now;
            u.IsActive = checkActive.Checked;
            u.IsAdmin = checkAdmin.Checked;

            string msg = new UserBLL().CreateUser(u);
            if(msg.Trim() == "")
            {
                Response.Write(@"<script> alert('User Added Successfully!') </script>");
            }
            else
            {
                Response.Write(@"<script> alert('Error Adding User Data!') </script>");
            }
        }
    }
}