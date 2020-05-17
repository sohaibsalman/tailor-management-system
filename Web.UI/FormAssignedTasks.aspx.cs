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
    public partial class FormAssignedTasks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<OrdersAssigned> list = new OrderBLL().GetPendingOrders();            
                if (list.Count <= 0)
                {
                    divOrdersAssigned.InnerHtml = "<div class='alert alert-danger'> No Orders Assigned Yet! </div>";
                }
                else
                {
                    gridOrdersAssigned.DataSource = list;
                    gridOrdersAssigned.DataBind();
                }
            }
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                data_bind();
            }
            else
            {
                List<OrdersAssigned> customerList = new OrderBLL().GetPendingOrders();
                var result = (from t in customerList where t.CustomerName.Contains(txtSearch.Text.Trim()) || t.OrderName.Contains(txtSearch.Text.Trim()) select t).ToList<OrdersAssigned>();
                gridOrdersAssigned.DataSource = result;
                gridOrdersAssigned.DataBind();
            }
        }

        private void data_bind()
        {
            gridOrdersAssigned.DataSource = new OrderBLL().GetPendingOrders();
            gridOrdersAssigned.DataBind();
        }
    }
}