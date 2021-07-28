using IT_SPARE.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IT_SPARE.App_Start
{
    public class Filter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ModelSession session = filterContext.RequestContext.HttpContext.Session["ModelSession"] == null ? null : (ModelSession)filterContext.RequestContext.HttpContext.Session["ModelSession"];

            var url = filterContext.HttpContext.Request.Url;

            if (session == null)
            {
                filterContext.Controller.TempData["Erro"] = true;
                filterContext.Controller.TempData["Message"] = "Session Expired. Please log in again.";
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary(
                    new { controller = "Login", action = "Index" }));
            }
        }
    }
}