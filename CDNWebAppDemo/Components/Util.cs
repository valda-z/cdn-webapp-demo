using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CDNWebAppDemo.Components
{
    public static class Util
    {
        public enum CDNType
        {
            AKAMAI,
            VERIZONE,
            LOCAL
        }

        public static string GetCDNURL(CDNType cdn)
        {
            switch (cdn)
            {
                case CDNType.AKAMAI:
                    return ConfigurationManager.AppSettings["CDNURLAKAMAI"];
                case CDNType.VERIZONE:
                    return ConfigurationManager.AppSettings["CDNURLVERIZONE"];
                case CDNType.LOCAL:
                    return "";
            }
            return "";
        }
    }
}