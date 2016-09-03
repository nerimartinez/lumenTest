using ServicesLayer.Interfaces;
using ServicesLayer.Models;
using ServicesLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcPWy.API
{
    public class LocationController : ApiController
    {
        private ILocationService _locationService;

        public LocationController (LocationService locationService)
        {
            _locationService = locationService;
        }

        // GET: api/Location
        public IEnumerable<Location> Get()
        {
            return _locationService.GetAll() ;
        }        
    }
}
