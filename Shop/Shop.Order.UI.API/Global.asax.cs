using System;
using System.Web.Http;
using System.Web.Http.Dependencies;

namespace Shop.Order.UI.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static IServiceProvider ServiceProvider;
        
        protected void Application_Start()
        {
            ServiceProvider = ContainerRegistry.Register();
            GlobalConfiguration.Configure(WebApiConfig.Register);           
        }
    }
}
