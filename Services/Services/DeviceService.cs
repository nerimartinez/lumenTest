using ServicesLayer.Interfaces;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesImplementations.Services
{
    public class DeviceService : IDeviceService
    {
        public List<Device> GetAll(string user)
        {
            List<Device> result = null;
            using (var db = new LumenContext())
            {
                result = db.Devices
                    .Include("Location")
                    .Include("Policy")
                    .Include("Manufacturer")
                    .Include("Model")                    
                    .Where(x=>x.UserEmail == user).ToList();                
            }
            return result;
        }

        public Device GetById(int Id)
        {
            Device result;
            using (var db = new LumenContext())
            {
                result = db.Devices
                    .Include("Location")
                    .Include("Policy")
                    .Include("Manufacturer")
                    .Include("Model")
                    .Single(x => x.Id == Id);
            }
            return result;
        }

        public void Add(Device device)
        {
            using (var db = new LumenContext())
            {
                device.Location = db.Locations.Single(x => x.Id == device.Location.Id);
                device.Policy = db.Policies.Single(x => x.Id == device.Policy.Id);
                device.Manufacturer = db.Manufacturers.Single(x => x.Id == device.Manufacturer.Id);
                device.Model = db.Models.Single(x => x.Id == device.Model.Id);
                db.Devices.Add(device);
                db.SaveChanges();
            }
        }

        public void Remove(int Id)
        {
            using (var db = new LumenContext())
            {
                var loc = db.Devices.SingleOrDefault(x => x.Id == Id);
                db.Devices.Remove(loc);
                db.SaveChanges();
            }
        }

        public void Edit(Device device)
        {
            using (var db = new LumenContext())
            {
                var dev = db.Devices.SingleOrDefault(x => x.Id == device.Id);
                dev.IpAddress = device.IpAddress;
                dev.IpType = device.IpType;
                
                dev.LoginEnablePassword = device.LoginEnablePassword;
                dev.LoginIpAddress = device.LoginIpAddress;
                dev.LoginPassword = device.LoginPassword;
                dev.LoginUserName = device.LoginUserName;
                
                dev.NIC1DefaultGateway = device.NIC1DefaultGateway;
                dev.NIC1IpAddress = device.NIC1NATIpAddress;
                dev.NIC1SubNetMask = device.NIC1SubNetMask;
                dev.NIC1NATIpAddress = device.NIC1NATIpAddress;
                dev.NIC2DefaultGateway = device.NIC2DefaultGateway;
                dev.NIC2IpAddress = device.NIC2IpAddress;
                dev.NIC2SubNetMask = device.NIC2SubNetMask;
                dev.NickName = device.NickName;
                
                dev.ZipCode = device.ZipCode;

                device.Location = db.Locations.Single(x => x.Id == device.Location.Id);
                device.Policy = db.Policies.Single(x => x.Id == device.Policy.Id);
                device.Manufacturer = db.Manufacturers.Single(x => x.Id == device.Manufacturer.Id);
                device.Model = db.Models.Single(x => x.Id == device.Model.Id);

                dev.Location = device.Location;
                dev.Policy = device.Policy;
                dev.Manufacturer = device.Manufacturer;
                dev.Model = device.Model;

                db.SaveChanges();
            }
        }
    }
}
