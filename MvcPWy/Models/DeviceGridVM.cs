using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPWy.Models
{
    public class DeviceGridVM
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string IpAddress { get; set; }
        public string Policy { get; set; }        
    }
}