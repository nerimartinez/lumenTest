using Services.Interfaces;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class PolicyService : IPolicyService
    {
        public List<Policy> GetAll()
        {
            List<Policy> result = null;
            using (var db = new LumenContext())
            {
                result = db.Policies.ToList();
            }
            return result;
        }
    }
}
