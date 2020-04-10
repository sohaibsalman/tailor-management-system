using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.BLL;

namespace Windows.UI
{
    public partial class FormAddMeasurementFile : Form
    {
        public FormAddMeasurementFile()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter File Name", "Error");
            }
            else
            {
                if(txtFileName.Text.Trim() != "")
                {
                    List<String> fileData = new List<string>();

                    fileData.Add(txtFileName.Text);

                    int count = tableMeasurements.RowCount - 1;

                    bool flag = true;

                    for (int i = 0; i < count; i++)
                    {
                        if(tableMeasurements.Rows[i].Cells[0].Value != null)
                        {
                            String data = tableMeasurements.Rows[i].Cells[0].Value.ToString();
                            fileData.Add(data);
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    if(flag)
                    {
                        new MeasurementsBLL().AddNewFile(fileData);
                        new MeasurementsBLL().CreateNewType(fileData);

                        MessageBox.Show("File Created Successfuly", "Success");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please Add some Measurement content!", "Error");
                    }

                }
                
                else
                {
                    MessageBox.Show("Please Enter File Name First", "Error");
                }
            }
        }
    }
}
