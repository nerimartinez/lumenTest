using ServicesLayer.Interfaces;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Services
{
    public class LocationService : ILocationService
    {
        public List<Location> GetAll()
        {
            List<Location> result = null;
            using (var db = new LumenContext())
            {
                result = db.Locations.ToList();
            }
            return result;
        }
    }
}
