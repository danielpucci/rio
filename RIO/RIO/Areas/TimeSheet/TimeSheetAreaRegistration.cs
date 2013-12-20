using System.Web.Mvc;

namespace RIO.Areas.TimeSheet
{
    public class TimeSheetAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "TimeSheet";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "TimeSheet_default",
                "TimeSheet/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
