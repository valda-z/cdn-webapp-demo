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
            var cdnRoot = Util.GetCDNURL(Util.CDNType.VERIZONE);
            var appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            bundles.UseCdn = true;

            //### lets try for jquery bundle some FallBack action ...
            var jqBundle = new ScriptBundle("~/bundles/jquery", string.Format("{0}/bundles/jquery?v={1}", cdnRoot, appVersion)).Include(
                        "~/Scripts/jquery-{version}.js");
            jqBundle.CdnFallbackExpression = "window.jQuery";
            bundles.Add(jqBundle);

            bundles.Add(new ScriptBundle("~/bundles/jqueryval", string.Format("{0}/bundles/jqueryval?v={1}", cdnRoot, appVersion)).Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr", string.Format("{0}/bundles/modernizr?v={1}", cdnRoot, appVersion)).Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", string.Format("{0}/bundles/bootstrap?v={1}", cdnRoot, appVersion)).Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css", string.Format("{0}/Content/css?v={1}", cdnRoot, appVersion)).Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
