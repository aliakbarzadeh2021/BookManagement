using System.Web.Http;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TagManagement.Command.Installer;
using TagManagement.Query.Installer;

namespace ServiceHost.Installer
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
         {
            container.Install(new CommandServiceInstaller());
            container.Install(new QueryServiceInstaller());
            
            container.Register(Classes.FromThisAssembly().BasedOn<ApiController>().LifestyleTransient());
            //container.Register(Classes.FromThisAssembly().Pick().WithServiceAllInterfaces().LifestyleTransient());

           // container.Register(Classes.FromThisAssembly()
           //.Pick().If(t => t.Name.EndsWith("Controller"))
           //.Configure(configurer => configurer.Named(configurer.Implementation.Name))
           ////.LifestylePerWebRequest()
           //.LifestyleScoped()
           // //.FromThisAssembly()
           // //    .BasedOn<ApiController>()
           // //   .LifestyleScoped()
           // );

        }
    }
}
