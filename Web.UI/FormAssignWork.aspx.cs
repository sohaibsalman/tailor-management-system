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
    public partial class FormAssignWork : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<Customer> customerList = new CustomerBLL().GetAllCustomers();
                ddlCustomers.DataSource = customerList;
                ddlCustomers.DataValueField = "ID";
                ddlCustomers.DataTextField = "Name";
                ddlCustomers.DataBind();

                List<Worker> workerList = new WorkerBLL().GetAllWorkers();
                //INTI WORKERS DROP DOWN
                ddlWorkers.DataSource = workerList;
                ddlWorkers.DataValueField = "ID";
                ddlWorkers.DataTextField = "Name";
                ddlWorkers.DataBind();

                //INIT WORKERS STATS TABLE
                gridWorkersInfo.DataSource = new WorkerBLL().GetWorkersStats(workerList);
                gridWorkersInfo.DataBind();

                ddlCustomers_SelectedIndexChanged(sender, e);
            }
        }
            

        protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ddlCustomers.SelectedItem.Value);
            ddlOrderName.DataSource = new OrderBLL().GetTypeOfMeasurement(id);
            ddlOrderName.DataBind();
        }

        protected void btnAssign_Click(object sender, EventArgs e)
        {
            int workerID = Convert.ToInt32(ddlWorkers.SelectedItem.Value);
            int customerID = Convert.ToInt32(ddlCustomers.SelectedItem.Value);

            string orderName = ddlOrderName.SelectedValue;
            int price = Convert.ToInt32(txtPrice.Text);


            if (new OrderBLL().AssingToWorker(customerID, workerID, orderName, price, System.DateTime.Now))
            {
                Response.Write("<script>alert('Work Assigned Successfully!')</script>");
                initPageData(sender, e);
            }
            else
            {
                Response.Write("<script>alert('Error Assigning the work!')</script>");
            }
        }
        private void initPageData(object sender, EventArgs e)
        {
            List<Customer> customerList = new CustomerBLL().GetAllCustomers();
            ddlCustomers.DataSource = customerList;
            ddlCustomers.DataValueField = "ID";
            ddlCustomers.DataTextField = "Name";
            ddlCustomers.DataBind();

            List<Worker> workerList = new WorkerBLL().GetAllWorkers();
            //INTI WORKERS DROP DOWN
            ddlWorkers.DataSource = workerList;
            ddlWorkers.DataValueField = "ID";
            ddlWorkers.DataTextField = "Name";
            ddlWorkers.DataBind();

            //INIT WORKERS STATS TABLE
            gridWorkersInfo.DataSource = new WorkerBLL().GetWorkersStats(workerList);
            gridWorkersInfo.DataBind();

            ddlCustomers_SelectedIndexChanged(sender, e);
        }
    }
    
}