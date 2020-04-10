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
    public partial class FormMeasurements : Form
    {
        public static Dictionary<string, int> measurementValues;
        public static String measurementName = "";

        public FormMeasurements()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new FormAddMeasurementFile().ShowDialog();
            FormMeasurements_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMeasurements_Load(object sender, EventArgs e)
        {
            string[] files = new MeasurementsBLL().GetFileNames();
            for (int i = 0; i < files.Length; i++) 
            {
                files[i] = RemovePath(files[i]);
            }
            cbxMeasurementType.DataSource = files;
        }

        private void cbxMeasurementType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = cbxMeasurementType.SelectedValue.ToString();

            DataTable dt = new MeasurementsBLL().GetMeasurementsFromFile(fileName);

            tableMeasurements.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            measurementValues = new Dictionary<string, int>();

            string path = cbxMeasurementType.SelectedValue.ToString();
            path = RemovePath(path);

            measurementName = path;

            int rows = tableMeasurements.RowCount;

            bool flag = false;

            for (int i = 0; i < rows; i++)
            {
                string name = tableMeasurements[1, i].Value.ToString();
                if (tableMeasurements[0, i].Value != null)
                {
                    int value = Convert.ToInt32((string)tableMeasurements[0, i].Value);
                    measurementValues.Add(name, value);
                }
                else
                {
                    flag = true;
                    MessageBox.Show("Please enter all the Measurements", "Error");
                    break;
                }
            }
            if(!flag)
                this.Close();
        }


        private string RemovePath(string path)
        {
            int index = path.LastIndexOf("/");
            path = path.Remove(0, index + 1);
            path = path.Replace(".txt", "");
            return path;
        }
    }
}
