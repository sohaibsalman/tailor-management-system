using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.Common;

namespace Web.UI
{
    public partial class FormReports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                lblTotalUsers.Text = new TMS.BLL.UserBLL().GetAllUsers().Count.ToString();
                lblTotalWorkers.Text = new TMS.BLL.WorkerBLL().GetAllWorkers().Count.ToString();
                lblTotalCustomers.Text = new TMS.BLL.CustomerBLL().GetAllCustomers().Count.ToString();


                List<Order> newOrders = new TMS.BLL.OrderBLL().GetNewOrders();
                if(newOrders.Count == 0)
                {
                    divPendingOrders.InnerHtml = "<div class='alert alert-danger'>No Pending Order found!</div>";
                }
                else
                {
                    gridPendingOrders.DataSource = newOrders;
                    gridPendingOrders.DataBind();
                }

                newOrders.Clear();

                List<OrdersAssigned> assignedOrders = new TMS.BLL.OrderBLL().GetPendingOrders();
                if (assignedOrders.Count == 0)
                {
                    divInProgressOrders.InnerHtml = "<div class='alert alert-danger'>No Order in Progress!</div>";
                }
                else
                {
                    gridInProgress.DataSource = assignedOrders;
                    gridInProgress.DataBind();
                }

                int completed = new TMS.BLL.OrderBLL().GetEarningsOfCompletedOrders();
                int pending = new TMS.BLL.OrderBLL().GetEarningsOfPendingOrders();
                int total = completed + pending;

                lblEarningsCompleted.Text += completed.ToString();
                lblEarningsPending.Text += pending.ToString();
                lblEarningsTotal.Text += total.ToString();
            }
        }


    }
}