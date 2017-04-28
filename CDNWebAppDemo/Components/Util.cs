using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CDNWebAppDemo.Components
{
    public static class Util
    {
        public static string GetCDNURL()
        {
            return ConfigurationManager.AppSettings["CDNURL"];
        }
    }
}