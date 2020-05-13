using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Common;
using TMS.DAL;

namespace TMS.BLL
{
    public class MeasurementsBLL
    {
        public void AddNewFile(List<string> fileData)
        {
            new MeasurementsDAL().AddNewFile(fileData);
        }

        public string[] GetFileNames()
        {
            return new MeasurementsDAL().GetFileNames();
        }

        public string[] GetFileNamesWeb(string path)
        {
            return new MeasurementsDAL().GetFileNamesWeb(path);
        }

        public DataTable GetMeasurementsFromFile(string filename)
        {
            return new MeasurementsDAL().GetMeasurementsFromFile(filename);
        }

        public void CreateNewType(List<string> fileData)
        {
            new MeasurementsDAL().CreateNewType(fileData);
        }

        public DataTable GetMeasurementsFromFileWeb(string fileName)
        {
            return new MeasurementsDAL().GetMeasurementsFromFileWeb(fileName);
        }

        public bool InsertMeasurements(Customer c, List<string> orderName)
        {
            return new MeasurementsDAL().InsertMeasurements(c, orderName);
        }
    }
}
