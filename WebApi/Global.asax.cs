using Clients.Employee;
using Poviders.Employee;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using WebApi.App_Start;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
       

        protected void Application_Start()
        {

            //var _container = new UnityContainer();
    
            //_container.RegisterType<IEmployeeClient, EmployeeClient>();
            //_container.RegisterType<IEmployeeProvider, EmployeeProvider>();
            
            //// Web API routes
            //GlobalConfiguration.Configuration.DependencyResolver = new UnityResolver(_container);

            // Web API routes


            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
