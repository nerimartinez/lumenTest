using Services.Interfaces;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ModelService : IModelService
    {
        public List<Model> GetAll(int manufacturerId)
        {
            List<Model> result = null;
            using (var db = new LumenContext())
            {
                result = db.Models.Where(x=>x.Manufacturer.Id == manufacturerId).ToList();
            }
            return result;
        }
    }
}
