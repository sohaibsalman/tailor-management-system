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
    public partial class FormAddWorker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();

            w.Address = txtAddress.Text;
            w.ContactNumber = txtNumber.Text;
            w.Name = txtName.Text;
            w.Salary = Convert.ToInt32(txtSalary.Text);
            w.JoiningDate = System.DateTime.Now;

            String msg = new WorkerBLL().AddWoker(w);
            if (msg.Trim() == "") 
            {
                Response.Write(@"<script> alert ('Worker Added Successfully') </script>");
            }
            else
            {
                Response.Write(@"<script> alert ('Error Adding the Worker ') </script>");
            }
        }
    }
}