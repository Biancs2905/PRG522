using System.Web;
using System.Web.Optimization;

namespace SummativePrjct
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/active").Include(
            "~/Scripts/active.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                       "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/cubeportfolio").Include(
                       "~/Scripts/cubeportfolio.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-fancybox").Include(
                        "~/Scripts/jquery-fancybox.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-migrate-3.0.0").Include(
                        "~/Scripts/jquery-migrate-3.0.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery.counterup").Include(
                        "~/Scripts/jquery.counterup.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.mmin.js"));

            bundles.Add(new ScriptBundle("~/bundles/magnific-popup").Include(
                        "~/Scripts/magnific-popup.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/owl-carousel").Include(
                        "~/Scripts/owl-carousel.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                        "~/Scripts/popper.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scrollup").Include(
                        "~/Scripts/scrollup.js"));

            bundles.Add(new ScriptBundle("~/bundles/slicknav").Include(
                        "~/Scripts/slicknav.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/waypoints").Include(
                        "~/Scripts/waypoints.min.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                                                    "~/Content/animate.min.css",
                                                    "~/Content/bootstrap-theme.css",
                                                    "~/Content/bootstrap-theme.css.map",
                                                    "~/Content/bootstrap-theme.min.css",
                                                    "~/Content/bootstrap-theme.min.css.map",
                                                    "~/Content/bootstrap.css",
                                                    "~/Content/bootstrap.css.map",
                                                    "~/Content/cubeportfplio.css",
                                                    "~/Content/font-awesome.css",
                                                    "~/Content/jquery.fancybox.min.css",
                                                    "~/Content/magnific-popup,min.css",
                                                    "~/Content/owl-carousel.min.css",
                                                    "~/Content/reset.css",
                                                    "~/Content/responsive.css",
                                                    "~/Content/Site.css",
                                                    "~/Content/Site-1.css",
                                                    "~/Content/Site-2.css",
                                                    "~/Content/Site-3.css",
                                                    "~/Content/Site-4.css"
                                                ));

        }
    }
}
