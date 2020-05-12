using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.BLL;

namespace Web.UI
{
    public partial class FormSearchUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                data_bind();
        }

        private void data_bind()
        {
            gridUsers.DataSource = new UserBLL().GetAllUsers();
            gridUsers.DataBind();
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