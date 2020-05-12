using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Providers.Entities;
using System.Web.UI.WebControls;
using TMS.BLL;
using TMS.Common;

namespace Web.UI
{
    public partial class FormUpdateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                data_bind();
        }

        private void data_bind()
        {
            gridUsers.DataSource = new UserBLL().GetAllUsers();
            gridUsers.DataBind();
        }

        protected void gridUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridUsers.PageIndex = e.NewPageIndex;
            data_bind();
        }

        protected void gridUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            TMS.Common.User u = new TMS.Common.User();

            u.ID = Convert.ToInt32(gridUsers.SelectedRow.Cells[1].Text);
            u.Name = gridUsers.SelectedRow.Cells[2].Text;
            u.Username = gridUsers.SelectedRow.Cells[3].Text;
            u.Password = gridUsers.SelectedRow.Cells[4].Text;
            u.RegistrationDate = Convert.ToDateTime(gridUsers.SelectedRow.Cells[5].Text);
            u.LastLogin = Convert.ToDateTime(gridUsers.SelectedRow.Cells[6].Text);

            Session["update_user"] = u;

            Response.Redirect("~/FormUpdateUserValues.aspx");
        }

        protected void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                data_bind();
            }
            else
            {
                List<TMS.Common.User> userList = new UserBLL().GetAllUsers(); 
                var result = (from t in userList where t.Name.ToLower().Contains(txtSearch.Text.ToLower().Trim()) || t.Username.Contains(txtSearch.Text.Trim()) select t).ToList<TMS.Common.User>();
                gridUsers.DataSource = result;
                gridUsers.DataBind();
            }
        }
    }
}