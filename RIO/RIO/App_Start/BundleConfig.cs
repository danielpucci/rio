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
            bundles.Add(new ScriptBundle("~/Bundles/Scripts/Plugins").Include("~/Content/Scripts/Plugins/jquery.*"));

            //Scripts:  Default
            bundles.Add(new ScriptBundle("~/Bundles/Scripts/Main").Include("~/Content/Scripts/main.js"));

            //CSS: VENDOR
            bundles.Add(new StyleBundle("~/Bundles/Styles/Plugins").Include("~/Content/Styles/Bootstrap/bootstrap.css"));

            //CSS: Default
            bundles.Add(new StyleBundle("~/Bundles/Styles/Main").Include("~/Content/Styles/main.css"));
           
        }
    }
}