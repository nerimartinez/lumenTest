using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Interfaces
{
    public interface ILocationService
    {
        /// <summary>
        /// Gets all the locations
        /// </summary>
        /// <returns></returns>
        List<Location> GetAll();
    }
}
