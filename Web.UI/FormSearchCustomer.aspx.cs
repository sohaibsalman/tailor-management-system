using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.Common;

namespace Web.UI
{
    public partial class FormSearchCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            data_bind();
        }

        protected void data_bind()
        {
            gridCustomer.DataSource = new TMS.BLL.CustomerBLL().GetAllCustomers();
            gridCustomer.DataBind();
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                data_bind();
            }
            else
            {
                List<Customer> customerList = new TMS.BLL.CustomerBLL().GetAllCustomers();
                var result = (from t in customerList where t.Name.Contains(txtSearch.Text.Trim()) || t.CNIC.Contains(txtSearch.Text.Trim()) select t).ToList<Customer>();
                gridCustomer.DataSource = result;
                gridCustomer.DataBind();
            }
        }
    }
}