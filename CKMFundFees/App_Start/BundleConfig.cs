using System.Web;
using System.Web.Optimization;

namespace CKMFundFees
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/vendors/jquery/dist/jquery.min.js",
                     "~/Scripts/bootstrap.js",
                     "~/vendors/bootstrap/dist/js/bootstrap.bundle.min.js",
                     "~/vendors/nprogress/nprogress.js",
                     "~/vendors/fastclick/lib/fastclick.js",
                     "~/build/js/custom.min.js",
                     "~/vendors/DataTables/DataTables-1.10.21/js/jquery.dataTables.min.js",
                     "~/vendors/DataTables/DataTables-1.10.21/js/dataTables.bootstrap.min.js"
                     ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/vendors/bootstrap/dist/css/bootstrap.min.css",
                      "~/vendors/font-awesome/css/font-awesome.min.css",
                      "~/vendors/nprogress/nprogress.css",
                      "~/build/css/custom.min.css",
                      "~/vendors/DataTables/DataTables-1.10.21/css/dataTables.bootstrap.min.css",
                      "~/vendors/DataTables/DataTables-1.10.21/css/jquery.dataTables.min.css"
                      ));
        }
    }
}









