using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPolicyService 
    {
        /// <summary>
        /// Gets all the policies
        /// </summary>
        /// <returns></returns>
        List<Policy> GetAll();
    }
}
