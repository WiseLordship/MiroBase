using System;

namespace MicroBase.Core.Models
{
    public class ServerDetails
    {
        public string MachineName { get; set; }

        public DateTimeOffset ServerTime => DateTimeOffset.Now;

        public string IpAddress { get; set; }
    }
}
