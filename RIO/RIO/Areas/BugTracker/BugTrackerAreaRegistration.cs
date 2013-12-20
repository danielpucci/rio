﻿using System.Web.Mvc;

namespace RIO.Areas.BugTracker
{
    public class BugTrackerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "BugTracker";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "BugTracker_default",
                "BugTracker/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
