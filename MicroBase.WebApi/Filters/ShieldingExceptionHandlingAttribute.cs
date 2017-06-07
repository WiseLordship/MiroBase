using System;
using System.Web.Mvc;

namespace MicroBase.WebApi.Filters
{
    public class ShieldingExceptionHandlingAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            throw new ApplicationException("Sucka");
        }
    }
}
