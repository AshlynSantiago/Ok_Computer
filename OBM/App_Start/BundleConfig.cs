﻿using System.Web;
using System.Web.Optimization;

namespace OBM
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
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/datatables.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/HomePage").Include(
                "~/Scripts/datatables.min.js",
                "~/Scripts/anime.min.js",
                "~/Scripts/HomePage.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/MatchDisplay").Include(
                "~/Scripts/moment.js",
                "~/Scripts/Chart.min.js",
                "~/Scripts/MatchDisplay.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/StandingsDisplay").Include(
                "~/Scripts/moment.js",
                "~/Scripts/Chart.min.js",
                "~/Scripts/randomColor.js",
                "~/Scripts/StandingsDisplay.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/TournamentDisplay").Include(
                "~/Scripts/datatables.min.js",
                "~/Scripts/jquery-ui.js",
                "~/Scripts/moment.js",
                "~/Scripts/Chart.min.js",
                "~/Scripts/randomColor.js",
                "~/Scripts/TournamentDisplay.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/OrganizerSearch").Include(
                "~/Scripts/datatables.min.js",
                "~/Scripts/OrganizerSearchTable.js"
                ));
        }
    }
}
