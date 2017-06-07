using System;
using System.Web;
using System.Web.Http;
using MicroBase.WebApi.Filters;

namespace MicroBase.WebApi.Controllers
{
    [RoutePrefix("api/Sample")]
    [ShieldingExceptionHandling]
    public class SampleController : ApiController
    {
        public HttpResponse Get()
        {
            throw new Exception("test");
        }

    }
}