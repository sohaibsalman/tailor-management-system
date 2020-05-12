using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.BLL;

namespace Web.UI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCountNewOrders.Text =  new OrderBLL().GetAllOrders().Count.ToString();
            lblCountCompletedOrders.Text = new OrderBLL().GetCompletedOrders().Count.ToString();
            lblCountPendingOrders.Text = new OrderBLL().GetPendingOrders().Count.ToString();

            WorkersDataBind();
        }

        private void WorkersDataBind()
        {
            gridWorkersList.DataSource = new WorkerBLL().GetAllWorkers();
            gridWorkersList.DataBind();
        }

        protected void gridWorkersList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridWorkersList.PageIndex = e.NewPageIndex;
            WorkersDataBind();
        }
    }
}