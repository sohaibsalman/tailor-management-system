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
    public partial class FormLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<User> users = new UserBLL().GetAllUsers();
                ddlUsernames.DataSource = users;

                ddlUsernames.DataValueField = "Username";
                ddlUsernames.DataTextField = "Username";
                ddlUsernames.DataBind();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            List<User> userList = new UserBLL().GetAllUsers();

            for (int i = 0; i < userList.Count; i++)
            {
                if(userList[i].Username == ddlUsernames.SelectedValue && userList[i].Password == txtPassword.Text)
                {
                    Session["user"] = userList[i];
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    string html = "<div class='alert alert-danger'>Incorrect Password</div>";
                    wrong_password.InnerHtml = html;
                }
            }

        }
    }
}