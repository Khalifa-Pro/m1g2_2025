﻿using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace m1g2_2025
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour développer et apprendre. Puis, lorsque vous êtes
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            // bundle js de mon template
            bundles.Add(new Bundle("~/bundles/jstemplate").Include(
                    "~/Scripts/bootstrap.js",
                    //< !--Vendor JS Files-- >
                    "~/assets/vendor/apexcharts/apexcharts.min.js",
                    "~/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                    "~/assets/vendor/chart.js/chart.umd.js",
                    "~/assets/vendor/echarts/echarts.min.js",
                    "~/assets/vendor/quill/quill.js",
                    "~/assets/vendor/simple-datatables/simple-datatables.js",
                    "~/assets/vendor/tinymce/tinymce.min.js",
                    "~/assets/vendor/php-email-form/validate.js",
                    //< !--Template Main JS File-- >
                    "~/assets/js/main.js"
/*                    "~/assets/js/EmployeeJS.js"
*/            ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            // le bundle css de mon template 
            bundles.Add(new StyleBundle("~/Content/csstemplate").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css",
                    "~/Content/PagedList.css",
                    //< !--Vendor CSS Files template-- >
                    "~/assets/vendor/bootstrap/css/bootstrap.min.css",
                    "~/assets/vendor/bootstrap-icons/bootstrap-icons.css",
                    "~/assets/vendor/boxicons/css/boxicons.min.css",
                    "~/assets/vendor/quill/quill.snow.css",
                    "~/assets/vendor/quill/quill.bubble.css",
                    "~/assets/vendor/remixicon/remixicon.css",
                    "~/assets/vendor/simple-datatables/style.css",
                    "~/assets/css/style.css"
            ));
        }
    }
}
