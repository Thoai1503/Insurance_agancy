﻿using System.Web;
using System.Web.Mvc;

namespace Insurance_Agency_web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
