using System;
using System.Configuration;
using System.Web.Http;
using Clients.Employee;
using Poviders.Employee;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;

namespace WebApi
{
    public static class WebApiConfig
    {


        public static void Register(HttpConfiguration config)
        {
            //// Web API configuration and services
            var _container = new UnityContainer();
            bool fakeImplementation = Convert.ToBoolean(ConfigurationManager.AppSettings["FakeImplementationClient"]);
            if (!fakeImplementation)
            {
                _container.RegisterType<IEmployeeClient, EmployeeClient>(
                    new HierarchicalLifetimeManager());
            }
            else
            {
                _container.RegisterType<IEmployeeClient, EmployeeClientMock>(
                    new HierarchicalLifetimeManager());
            }
          
            _container.RegisterType<IEmployeeProvider, EmployeeProvider>(
                new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityDependencyResolver(_container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


        }
    }
}
