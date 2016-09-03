using Services.Interfaces;
using Services.Services;
using ServicesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcPWy.API
{
    public class ModelController : ApiController
    {
        private IModelService _modelService;

        public ModelController(ModelService modelService)
        {
            _modelService = modelService;
        }
        // GET: api/Model
        public IEnumerable<Model> Get(int manufacturerId)
        {
            return new ModelService().GetAll(manufacturerId);
        }        
    }
}
