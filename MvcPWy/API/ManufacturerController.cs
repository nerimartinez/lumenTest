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
    public class ManufacturerController : ApiController
    {
        private IManufacturerService _manufacturerService;

        public ManufacturerController(ManufacturerService manufacturerService)
        {
            _manufacturerService = manufacturerService;
        }

        // GET: api/Manufacturer
        public IEnumerable<Manufacturer> Get()
        {
            return _manufacturerService.GetAll() ;
        }        
    }
}
