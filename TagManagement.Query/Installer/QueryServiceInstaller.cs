
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Infrastructure.Repository;
using TagManagement.Repository;

namespace TagManagement.Query.Installer
{
    public class QueryServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly().BasedOn(typeof(IBookQueryRepository<,>)).WithServiceAllInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().BasedOn(typeof(IQueryRepository<,>)).WithServiceAllInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().Pick().WithServiceAllInterfaces().LifestyleTransient());
        }
    }
}
