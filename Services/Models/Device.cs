using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Models
{
    public class Device
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public virtual Manufacturer Manufacturer { get; set; }
        [Required]
        public virtual Model Model { get; set; }
        [Required]
        public virtual Policy Policy { get; set; }
        [Required]
        public virtual Location Location { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string IpAddress { get; set; }
        [Required]
        public int IpType { get; set; }

        [Required]
        public string NIC1IpAddress { get; set; }
        [Required]
        public string NIC1SubNetMask { get; set; }
        [Required]
        public string NIC1DefaultGateway { get; set; }
        [Required]
        public string NIC1NATIpAddress { get; set; }

        [Required]
        public string NIC2IpAddress { get; set; }
        [Required]
        public string NIC2SubNetMask { get; set; }
        [Required]
        public string NIC2DefaultGateway { get; set; }

        public string LoginIpAddress { get; set; }
        public string LoginUserName { get; set; }
        public string LoginPassword { get; set; }
        public string LoginEnablePassword { get; set; }
    }
}
