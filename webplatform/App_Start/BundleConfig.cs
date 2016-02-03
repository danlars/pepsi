using System.Web;
using System.Web.Optimization;

namespace webplatform
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            //bundles.Add(new ScriptBundle("~/bundles/jquery-fancybox").Include(
            //            "~/Scripts/jquery.fancybox*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-fancybox").Include(
            "~/Scripts/jquery.fancybox.*"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-colorpicker").Include(
            "~/Scripts/colorpicker.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/bootstrap-datepicker.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/jquery.fancybox*",
                      "~/Content/bootstrap-datepicker.min.css"));

            bundles.Add(new StyleBundle("~/Content/colorpicker").Include(
                      "~/Content/colorpicker.css"));
        }
    }
}
