using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TMS.BLL;

namespace Web.UI
{
    public partial class FormAddNewFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddName_Click(object sender, EventArgs e)
        {
            listMeasurmentName.Items.Add(txtMeasurementName.Text);
            txtMeasurementName.Text = "";
        }

        protected void btnAddFile_Click(object sender, EventArgs e)
        {

            String path = @"~/files";
            String ph_path = Server.MapPath(path) + "\\" + txtFileName.Text;

            List<String> fileData = new List<string>();

            for (int i = 0; i < listMeasurmentName.Items.Count; i++)
            {
                listMeasurmentName.SelectedIndex = i;
                fileData.Add(listMeasurmentName.SelectedValue);
            }

            new MeasurementsBLL().AddNewFile(fileData, ph_path);
            new MeasurementsBLL().CreateNewType(fileData, txtFileName.Text);

            Response.Write("<script> alert('File Added Successfully'); </script>");

        }
    }
}