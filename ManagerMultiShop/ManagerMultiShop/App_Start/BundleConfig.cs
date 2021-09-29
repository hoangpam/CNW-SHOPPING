using System.Web;
using System.Web.Optimization;

namespace ManagerMultiShop
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //web site đăng nhập hiệu ứng
                        //"~/https://cpwebassets.codepen.io/assets/common/stopExecutionOnTimeout-157cd5b220a5c80d4ff8e0e70ac069bffd87a61252088146915e8726e5d9f147.js",
                        //"~/https://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js",
                        //"~/https://cdnjs.cloudflare.com/ajax/libs/howler/1.1.17/howler.min.js",
                        //"~/https://s3-us-west-2.amazonaws.com/s.cdpn.io/6859/tween.min_1.js",
                        //"~/https://cdnjs.cloudflare.com/ajax/libs/html2canvas/0.4.1/html2canvas.js",
                        //"~/Scripts/rendered-js.js",
                        //<!--Hiệu ứng mưa-->
                        "~/Content/assets/js/rain.js",
                        //< !--Latest jQuery-- >
                        "~/Content/assets/js/jquery-1.12.4.min.js",
                        //< !--Latest compiled and minified Bootstrap-- >
                        "~/Content/assets/bootstrap/js/bootstrap.js",
                        //< !--modernizer JS-- >
                        "~/Content/assets/js/modernizr.custom.js",
                        //< !--magnific - popup js-- >
                        "~/Content/assets/js/jquery.magnific-popup.js",
                        //< !--stellar js-- >
                        "~/Content/assets/js/jquery.stellar.min.js",
                        //< !--slick js-- >
                        "~/Content/assets/js/slick.js",
                        //< !--countdown js-- >
                        "~/Content/assets/js/jquery.countdown.js",
                        //< !--wow js-- >
                        "~/Content/assets/js/wow.min.js",
                        //< !--ajaxchimp js-- >
                        "~/Content/assets/js/ajaxchimp.min.js",
                        //< !--form - contact js-- >
                        "~/Content/assets/js/form-contact.js",
                        //< !--main js-- >
                        "~/Content/assets/js/main.js",
                       

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
                      "~/Content/bootstrap.css",
                      //< !--login animate-- >
                      "~/Content/login-animate.css",
                      "~/Content/assets/css/rain.css",
                      //< !--Latest Bootstrap min CSS-- >
                      "~/Content/assets/bootstrap/css/bootstrap.css",
                      //< !--Font Awesome CSS-- >
                      "~/Content/assets/fonts/font-awesome.css",
                      //< !--magnific - popup Css-- >
                      "~/Content/assets/css/magnific-popup.css",
                      //< !--animate Css-- >
                      "~/Content/assets/css/animate.css",
                      //< !--slick Css-- >
                      "~/Content/assets/css/slick.css",
                      //< !--Style CSS-- >
                      "~/Content/assets/css/style.css",
                      //< !--Responsive CSS-- >
                      "~/Content/assets/css/responsive.css",
                     
                      "~/Content/site.css"));
        }
    }
}
