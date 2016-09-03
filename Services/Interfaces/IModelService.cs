using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IModelService
    {
        /// <summary>
        /// Gets all the models of a certain manufacturer
        /// </summary>
        /// <param name="manufacturerId"></param>
        /// <returns></returns>
        List<Model> GetAll(int manufacturerId);
    }
}
