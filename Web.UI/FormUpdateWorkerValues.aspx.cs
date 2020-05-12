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
    public partial class FormUpdateWorkerValues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["update_worker"] == null)
                {
                    Response.Redirect("~/FormUpdateWorker.aspx");
                }
                else
                {
                    Worker w = (Worker)Session["update_worker"];
                    txtName.Text = w.Name;
                    txtAddress.Text = w.Address;
                    txtNumber.Text = w.ContactNumber;
                    txtSalary.Text = w.Salary.ToString();
                }
            }
         }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtNumber.Text != "" && txtAddress.Text != "" && txtSalary.Text != "") 
            {
                Worker w = new Worker();
                w.ID = ((Worker)Session["update_worker"]).ID;
                w.Name = txtName.Text;
                w.Address = txtAddress.Text;
                w.ContactNumber = txtNumber.Text;
                w.Salary = Convert.ToInt32(txtSalary.Text);
                if(new WorkerBLL().UpdateWorker(w))
                {
                    Response.Write("<script> alert('Worker Updated Successfully!') </script>");
                }
                else
                {
                    Response.Write("<script> alert('Error Updating the worker!') </script>");
                }
            }
            else
            {
                Response.Write("<script> alert('Pleae fill all text fields!') </script>");
            }
        }
    }
}