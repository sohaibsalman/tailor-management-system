using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.Common;

namespace Web.UI
{
    public partial class FormSearchWorker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            data_bind();
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                data_bind();
            }
            else
            {
                List<Worker> workerList = new TMS.BLL.WorkerBLL().GetAllWorkers();
                var result = (from t in workerList where t.Name.Contains(txtSearch.Text.Trim()) || t.ContactNumber.Contains(txtSearch.Text.Trim()) select t).ToList<Worker>();
                gridCustomers.DataSource = result;
                gridCustomers.DataBind();
            }
        }

        private void data_bind()
        {
            gridCustomers.DataSource = new TMS.BLL.WorkerBLL().GetAllWorkers();
            gridCustomers.DataBind();
        }

    }
}