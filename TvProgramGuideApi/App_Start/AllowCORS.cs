using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace TvProgramGuideApi.App_Start
{
    public class AllowCORS : ActionFilterAttribute
    {

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext == null)
            {
                throw new ArgumentNullException("actionExecutedContext");
            }
            else
            {
                actionExecutedContext.Response.Headers.Remove("Access-Control-Allow-Origin");
                actionExecutedContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            }
            base.OnActionExecuted(actionExecutedContext);
        }


    }
}