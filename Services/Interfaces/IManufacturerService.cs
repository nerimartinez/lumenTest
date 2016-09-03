using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IManufacturerService
    {
        /// <summary>
        /// Gets all the manufacturers
        /// </summary>
        /// <returns></returns>
        List<Manufacturer> GetAll();
    }
}
