using System;
using System.Web.Configuration;
using GoogleAnalyticsTracker.WebAPI2;

namespace example.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,
        Inherited = true, AllowMultiple = true)]
    public class GoogleAnalyticsAttribute : ActionTrackingAttribute
    {
        public GoogleAnalyticsAttribute() :
            base(WebConfigurationManager.AppSettings["GoogleAnalyticsIdentifier"])
        { }
    }
}
