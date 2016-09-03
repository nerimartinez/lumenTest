using MvcPWy.Helpers;
using MvcPWy.Models;
using ServicesImplementations.Services;
using ServicesLayer.Interfaces;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace MvcPWy.API
{
    public class DeviceController : ApiController
    {
        private IDeviceService _deviceService;

        public DeviceController(DeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        // GET: api/Device
        [Authorize]
        public List<DeviceGridVM> Get()
        {
            List<DeviceGridVM> result = null;            
            result = _deviceService.GetAll(User.Identity.Name).Select(x=>DeviceMapper.MapToVM(x)).ToList();
            return result;
        }        

        // GET: api/Device/5
        public Device Get(int id)
        {
            Device result = null;
            result = _deviceService.GetById(id);
            return result;
        }

        // POST: api/Device
        [Authorize]
        public DeviceGridVM Post([FromBody]DeviceVM devVm)
        {
            var newDev =DeviceMapper.MapToDev(devVm);
            newDev.UserEmail = User.Identity.Name;
            _deviceService.Add(newDev);
            return DeviceMapper.MapToVM(newDev);
        }

        // PUT: api/Device/5
        public DeviceGridVM Put(DeviceVM dev)
        {
            var mappedDevice = DeviceMapper.MapToDev(dev);
            _deviceService.Edit(mappedDevice);
            return DeviceMapper.MapToVM(mappedDevice);
        }

        // DELETE: api/Device/5
        public void Delete(int id)
        {
            _deviceService.Remove(id);
        }
    }
}
