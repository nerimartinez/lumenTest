using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Interfaces
{
    public interface IDeviceService
    {
        /// <summary>
        /// Gets all the devices of a given user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        List<Device> GetAll(string user);

        /// <summary>
        /// Gets a device by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Device GetById(int Id);

        /// <summary>
        /// Adds a new device
        /// </summary>
        /// <param name="device"></param>
        void Add(Device device);

        /// <summary>
        /// Removes a device
        /// </summary>
        /// <param name="Id"></param>
        void Remove(int Id);

        /// <summary>
        /// Edits a device
        /// </summary>
        /// <param name="device"></param>
        void Edit(Device device);
    }
}
