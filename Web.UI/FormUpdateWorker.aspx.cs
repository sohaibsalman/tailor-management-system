using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.Common;

namespace Web.UI.Sass
{
    public partial class FormUpdateWorker : System.Web.UI.Page
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

        protected void gridCustomers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridCustomers.PageIndex = e.NewPageIndex;
            data_bind();
        }

        protected void gridCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Worker w = new Worker();
            w.ID = Convert.ToInt32(gridCustomers.SelectedRow.Cells[1].Text);
            w.Name = gridCustomers.SelectedRow.Cells[2].Text;
            w.Address = gridCustomers.SelectedRow.Cells[3].Text;
            w.ContactNumber = gridCustomers.SelectedRow.Cells[4].Text;
            w.JoiningDate = Convert.ToDateTime(gridCustomers.SelectedRow.Cells[5].Text);
            w.Salary = Convert.ToInt32(gridCustomers.SelectedRow.Cells[6].Text);

            Session["update_worker"] = w;

            Response.Redirect("~/FormUpdateWorkerValues.aspx");
        }
    }
}