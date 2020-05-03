using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.Common;

namespace Web.UI
{
    public partial class TMS_Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                User user = (User)Session["user"];
                linkNavUser.Text = user.Name;
                linkSideUser.Text = user.Name;
            }
            else
            {
                Response.Redirect("~/FormLogin.aspx");
            }      
        }

        protected void linkLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/FormLogin.aspx");
        }
    }
} 