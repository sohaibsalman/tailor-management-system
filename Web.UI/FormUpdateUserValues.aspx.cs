using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.UI
{
    public partial class FormUpdateUserValues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["update_user"] == null)
                {
                    Response.Redirect("~/FormUpdateUser.aspx");
                }
                else
                {
                    TMS.Common.User u = (TMS.Common.User)Session["update_user"];

                    txtName.Text = u.Name;
                    txtPassword.Text = u.Password;
                    txtUsername.Text = u.Username;
                    checkActive.Checked = u.IsActive;
                    checkAdmin.Checked = u.IsAdmin;

                }
            }           
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            TMS.Common.User u = new TMS.Common.User();

            u.ID = ((TMS.Common.User)Session["update_user"]).ID;
            u.Name = txtName.Text;
            u.Password = txtPassword.Text;
            u.Username = txtUsername.Text;
            u.IsActive = checkActive.Checked;
            u.IsAdmin = checkAdmin.Checked;

            string msg = new TMS.BLL.UserBLL().UpdateUser(u);

            if (msg.Trim().ToLower() != "error")
            {
                Response.Write("<script> alert('User Updated Successfully!') </script>");
            }
            else
            {
                Response.Write("<script> alert('Error Updating the User!') </script>");
            }
        }
    }
}