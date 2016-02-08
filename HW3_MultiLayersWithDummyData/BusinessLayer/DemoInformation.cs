using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataAccessLayer;
using Models;
using System.Data;

namespace BusinessLayer
{
    public class DemoInformation
    {
        public static List<IndivDemographics> GetDemoData()
        {
            IndivDemographics IndivDemo = new IndivDemographics();
            var IndivDemoList = new List<IndivDemographics>();
            DataSet dsGetDemographicsReport = new DataSet();
            dsGetDemographicsReport = DADemoInformation.GetDemographics();

            if (dsGetDemographicsReport.Tables.Count > 0)
            { 
                IndivDemoList = dsGetDemographicsReport.Table[0].AsEnumerable().Select(m => new DemographicInformation
                {
                    FirstName = Convert.ToString(m["FirstName"]),
                    LastName = Convert.ToString(m["LastName"]),
                    Sex = Convert.ToString(m["Sex"]),
                    Address = Convert.ToString(m["Address"])
                }).ToList();
            }
        }
    }
}
