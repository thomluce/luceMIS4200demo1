﻿using System.Web;
using System.Web.Mvc;

namespace luceMIS4200demo1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
