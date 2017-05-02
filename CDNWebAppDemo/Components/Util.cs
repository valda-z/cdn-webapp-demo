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

        public static string GetCDNURL(CDNType cdn, bool isSSL)
        {
            string cdnUrl = "";
            switch (cdn)
            {
                case CDNType.AKAMAI:
                    cdnUrl = ConfigurationManager.AppSettings["CDNURLAKAMAI"];
                    break;
                case CDNType.VERIZONE:
                    cdnUrl = ConfigurationManager.AppSettings["CDNURLVERIZONE"];
                    break;
                case CDNType.LOCAL:
                    cdnUrl = "";
                    break;
            }

            if (isSSL)
            {
                cdnUrl = cdnUrl.Replace("http://", "https://");
            }
            return cdnUrl;
        }
    }
}