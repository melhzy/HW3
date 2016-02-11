using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
    public class DADemoInformation
    {
        public static DataSet GetDemographics()
        {
            DataSet dsGetDemographicsReport = new DataSet();

            dsGetDemographicsReport.DataSetName = "Demographics";

            DataTable 
            
            dt = new DataTable("BasicInformation");
            
            dt.Clear();
            
            dt.Columns.Add(new DataColumn("FirstName", typeof(string)));
            dt.Columns.Add(new DataColumn("LastName", typeof(string)));
            dt.Columns.Add(new DataColumn("Sex", typeof(string)));
            dt.Columns.Add(new DataColumn("Address", typeof(string)));

            DataRow 
            
            dr = dt.NewRow();
            dr["FirstName"] = "David";
            dr["LastName"] = "Johnson";
            dr["Sex"] = "Male";
            dr["Address"] = "111 Johns Drive, Mechanicsburg, PA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "John";
            dr["LastName"] = "Williams";
            dr["Sex"] = "Male";
            dr["Address"] = "433 Kings Road, Middletown, PA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "Pete";
            dr["LastName"] = "Queen";
            dr["Sex"] = "Female";
            dr["Address"] = "25 Rings Road, Atlanta, GA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "Jaswi";
            dr["LastName"] = "Edwars";
            dr["Sex"] = "Female";
            dr["Address"] = "121 Manner Drive, Camp Hill, PA";
            dt.Rows.Add(dr);

            dsGetDemographicsReport.Tables.Add(dt);

            return dsGetDemographicsReport;
        }
    }
}
