using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.BLL;

namespace Web.UI
{
    public partial class FormAddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                string[] files = new MeasurementsBLL().GetFileNamesWeb();
                for (int i = 0; i < files.Length; i++)
                {
                    files[i] = RemovePath(files[i]);
                }

                ddlMeasurementType.DataSource = files;
                ddlMeasurementType.DataBind();
                ddlMeasurementType.SelectedIndex = 0;
            }
        }

        private string RemovePath(string path)
        {
            int index = path.LastIndexOf("\\");
            path = path.Remove(0, index + 1);
            path = path.Replace(".txt", "");
            return path;
        }

        protected void ddlMeasurementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = ddlMeasurementType.SelectedValue;
            DataTable dt = new MeasurementsBLL().GetMeasurementsFromFileWeb(fileName);
            gridMeasurements.DataSource = dt;
            gridMeasurements.DataBind();
        }

        protected void gridMeasurements_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
        }
    }
}