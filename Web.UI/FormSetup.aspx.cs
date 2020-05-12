using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.UI
{
    public partial class FormSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                Response.Redirect("~/FormLogin.aspx");
            }
        }

        protected void linkNewCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormAddCustomer.aspx");
        }

        protected void linkNewWorker_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormAddWorker.aspx");
        }

        protected void linkNewUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormAddUser.aspx");
        }

        protected void linkUpdateCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormUpdateCustomer.aspx");
        }

        protected void linkUpdateWorker_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormUpdateWorker.aspx");
        }

        protected void linkUpdateUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormUpdateUser.aspx");
        }

        protected void linkDeleteCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormDeleteCustomer.aspx");
        }

        protected void linkDeleteWorker_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormDeleteWorker.aspx");
        }

        protected void linkDeleteUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormDeleteUser.aspx");
        }
    }
}