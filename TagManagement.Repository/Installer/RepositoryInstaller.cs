using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Infrastructure.Repository;
using TagManagement.Domain.Interface;

namespace TagManagement.Repository.Installer
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly().BasedOn(typeof(IRepository<,>)).WithServiceAllInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().BasedOn(typeof(IQueryRepository<,>)).WithServiceAllInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().BasedOn(typeof(IBookRepository)).WithServiceAllInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().BasedOn(typeof(ITagRepository)).WithServiceAllInterfaces().LifestyleTransient());

           
        }
    }
}
