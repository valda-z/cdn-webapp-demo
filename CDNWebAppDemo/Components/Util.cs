using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CDNWebAppDemo.Components
{
    public static class Util
    {
        public static string GetCDNURL()
        {
            return CDNWebAppDemo.Properties.Settings.Default.CDNURL;
        }
    }
}