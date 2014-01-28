using System.Web;
using System.Web.Optimization;

namespace RIO
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            //Scripts: Plugins
            bundles.Add(new ScriptBundle("~/Bundles/Scripts/Plugins")
                .Include("~/Content/Scripts/Plugins/jquery.js")
                .Include("~/Content/Scripts/Plugins/jquery.mask.js")
                .Include("~/Content/Scripts/Plugins/moment-with-langs.min.js")
                .Include("~/Content/Scripts/Plugins/bootstrap.js"));

            //Scripts:  Default
            bundles.Add(new ScriptBundle("~/Bundles/Scripts/Main").Include("~/Content/Scripts/main.js"));

            //CSS: Default
            bundles.Add(new StyleBundle("~/Bundles/Styles/Main").Include("~/Content/Styles/main.css"));
           
        }
    }
}