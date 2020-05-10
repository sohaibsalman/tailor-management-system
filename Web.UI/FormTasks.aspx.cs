using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.UI
{
    public partial class FormAssigWork : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void linkAssignWork_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormAssignWork.aspx");
        }

        protected void linkCompleteWork_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormCompleteOrder.aspx");
        }

        protected void linkAssignedTasks_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/FormAssignedTasks.aspx");
        }
    }
}