using MicroBase.Core.Models;
using System;
using System.Net;
using System.Web.Http;
using MicroBase.WebApi.Filters;

namespace MicroBase.WebApi.Controllers
{
    [RoutePrefix("api/System")]
    [ShieldingExceptionHandling]
    public class SystemController : ApiController
    {
        [Route("Time")]
        public DateTime GetServerTime()
        {
            return DateTime.Now;
        }

        [Route("Name")]
        public string GetServerName()
        {
            return Environment.MachineName;
        }

        [Route("IP")]
        public string GetServerIpAddress()
        {

            var hostName = Dns.GetHostName();
            var ipAddress = Dns.GetHostEntry(hostName).AddressList[0].ToString();
            return ipAddress;
        }

        [Route("Details")]
        public ServerDetails GetServerDetails()
        {
            return new ServerDetails
            {
                IpAddress = GetServerIpAddress(),
                MachineName = GetServerName()
            };
        }
    }
}