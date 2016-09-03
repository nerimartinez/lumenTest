using MvcPWy.Models;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPWy.Helpers
{
    public static class DeviceMapper
    {
        public static DeviceGridVM MapToVM(Device dev)
        {
            return new DeviceGridVM()
            {
                Id = dev.Id,
                NickName = dev.NickName,
                IpAddress = dev.IpAddress,
                Manufacturer = dev.Manufacturer.Name,
                Model = dev.Model.Name,
                Policy = dev.Policy.Value
            };
        }

        public static Device MapToDev(DeviceVM devVm)
        {
            var dev = new Device();
            dev.IpAddress = devVm.IpAddress;
            dev.IpType = devVm.IpType;
            dev.Location = new Location() { Id = devVm.LocationId };
            dev.LoginEnablePassword = devVm.LoginEnablePassword;
            dev.LoginIpAddress = devVm.LoginIpAddress;
            dev.LoginPassword = devVm.LoginPassword;
            dev.LoginUserName = devVm.LoginUserName;
            dev.Manufacturer = new Manufacturer() { Id = devVm.ManufacturerId };
            dev.Model = new Model() { Id = devVm.ModelId };
            dev.NIC1DefaultGateway = devVm.NIC1DefaultGateway;
            dev.NIC1IpAddress = devVm.NIC1NATIpAddress;
            dev.NIC1SubNetMask = devVm.NIC1SubNetMask;
            dev.NIC2DefaultGateway = devVm.NIC2DefaultGateway;
            dev.NIC1NATIpAddress = devVm.NIC1NATIpAddress;
            dev.NIC2IpAddress = devVm.NIC2IpAddress;
            dev.NIC2SubNetMask = devVm.NIC2SubNetMask;
            dev.NickName = devVm.NickName;
            dev.Policy = new Policy() { Id = devVm.PolicyId };
            dev.ZipCode = devVm.ZipCode;
            dev.Id = devVm.Id;
            return dev;
        }
    }
}