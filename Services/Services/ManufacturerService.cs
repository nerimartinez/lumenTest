using Services.Interfaces;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ManufacturerService : IManufacturerService
    {
        public List<Manufacturer> GetAll()
        {
            List<Manufacturer> result = null;
            using (var db = new LumenContext())
            {
                result = db.Manufacturers.ToList();
            }
            return result;
        }
    }
}
