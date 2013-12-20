using System.Web;
using System.Web.Optimization;

namespace RIO
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            //Scripts: VENDOR
            bundles.Add(new ScriptBundle("~/Bundles/Scripts/Vendor").Include("~/Scripts/Vendor/jquery.*"));

            //Scripts:  Default
            bundles.Add(new ScriptBundle("~/Bundles/Scripts/Main").Include("~/Scripts/Main.js"));

            //CSS: VENDOR
            bundles.Add(new StyleBundle("~/Bundles/Styles/Vendor").Include("~/Content/Styles/Bootstrap/style.css"));

            //CSS: Default
            bundles.Add(new StyleBundle("~/Bundles/Styles/Main").Include("~/Content/Styles/default.css"));
           
        }
    }
}