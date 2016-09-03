using Microsoft.Practices.Unity;
using MvcPWy.DI;
using Services.Interfaces;
using Services.Services;
using ServicesImplementations.Services;
using ServicesLayer.Interfaces;
using ServicesLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcPWy
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            var container = new UnityContainer();
            container.RegisterType<ILocationService, LocationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IDeviceService, DeviceService>(new HierarchicalLifetimeManager());
            container.RegisterType<IManufacturerService, ManufacturerService>(new HierarchicalLifetimeManager());
            container.RegisterType<IModelService, ModelService>(new HierarchicalLifetimeManager());
            container.RegisterType<IPolicyService, PolicyService>(new HierarchicalLifetimeManager());            
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}
