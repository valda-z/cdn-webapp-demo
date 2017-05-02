using CDNWebAppDemo.Components;
using System.Reflection;
using System.Web;
using System.Web.Optimization;

namespace CDNWebAppDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //enable CDN loading 
            var cdnRoot = Util.GetCDNURL(Util.CDNType.AKAMAI, true);
            var appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            bundles.UseCdn = true;

            //### lets try for jquery bundle some FallBack action ...
            var jqBundle = new ScriptBundle("~/bundles/myappjs", string.Format("{0}/bundles/myappjs?v={1}", cdnRoot, appVersion)).Include(
                          "~/Scripts/jquery-{version}.js",
                          "~/Scripts/bootstrap.js",
                          "~/Scripts/respond.js",
                          "~/Scripts/jquery.validate*",
                          "~/Scripts/modernizr-*"
                      );
            jqBundle.CdnFallbackExpression = "window.jQuery";
            bundles.Add(jqBundle);

            bundles.Add(new StyleBundle("~/Content/css", string.Format("{0}/Content/css?v={1}", cdnRoot, appVersion)).Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
