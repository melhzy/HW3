﻿using System.Web;
using System.Web.Mvc;

namespace HW3_MultiLayersWithDummyData
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
