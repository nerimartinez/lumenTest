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
    public class PolicyController : ApiController
    {
        private IPolicyService _policyService;

        public PolicyController(PolicyService policyService)
        {
            _policyService = policyService;
        }
        // GET: api/Policy
        public IEnumerable<Policy> Get()
        {
            return new PolicyService().GetAll();
        }
    }
}
