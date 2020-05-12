using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.BLL;

namespace Web.UI
{
    public partial class FormCompleteOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gridOrdersInfo.DataSource = new OrderBLL().GetPendingOrders();
            gridOrdersInfo.DataBind();
        }

        protected void gridOrdersInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(gridOrdersInfo.SelectedRow.Cells[3].Text);

            if (new OrderBLL().FinishOrder(orderId))
            {
                Response.Write(@"<script>alert('Order Finished'!)</script>");
                Page_Load(sender, e);
            }
            else
            {
                Response.Write(@"<script>alert('Error Finishing Order!')</script>");
            }
        }
    }
}