using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPWy.Models
{
    public class DeviceVM
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public int ManufacturerId { get; set; }
        public int ModelId { get; set; }
        public int PolicyId { get; set; }
        public int LocationId { get; set; }
        public int ZipCode { get; set; }
        public string IpAddress { get; set; }
        public int IpType { get; set; }

        public string NIC1IpAddress { get; set; }
        public string NIC1SubNetMask { get; set; }
        public string NIC1DefaultGateway { get; set; }
        public string NIC1NATIpAddress { get; set; }

        public string NIC2IpAddress { get; set; }
        public string NIC2SubNetMask { get; set; }
        public string NIC2DefaultGateway { get; set; }        

        public string LoginIpAddress { get; set; }
        public string LoginUserName { get; set; }
        public string LoginPassword { get; set; }
        public string LoginEnablePassword { get; set; }

    }
}