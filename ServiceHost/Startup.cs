using System.Web.Http;
using Owin;
using ServiceHost.Installer;
using ServiceHost.Resolver;

namespace ServiceHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var bootstrap = new DependencyContainer();
            bootstrap.Start();

            var config = new HttpConfiguration
            {
                DependencyResolver = new ApiDependencyResolver(DependencyContainer.Container)
            };
            ApiMapConfig(config);
            
            appBuilder.UseWebApi(config);
        }

        public void ApiMapConfig(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
        }
    }
}
