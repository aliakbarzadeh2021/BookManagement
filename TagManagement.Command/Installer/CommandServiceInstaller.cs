using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Infrastructure.CommandClass;
using TagManagement.Command.CommandBus;
using TagManagement.Command.CommandHandlers;
using TagManagement.Command.Commands;
using TagManagement.Domain.Installer;
using TagManagement.Repository.Installer;

namespace TagManagement.Command.Installer
{
    public class CommandServiceInstaller : IWindsorInstaller
    {
        public static IWindsorContainer Container { get; set; }
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            Container = container;
            container.Install(new DomainInstaller());
            container.Install(new RepositoryInstaller());

            container.Register(Classes.FromThisAssembly()
                .BasedOn(typeof(ICommand)).WithServiceAllInterfaces());
            container.Register(Types.FromThisAssembly()
                      .BasedOn(typeof(ICommandHandler<>)).WithServiceAllInterfaces().LifestyleTransient());
            container.Register(Classes.FromThisAssembly().BasedOn(typeof(ICommandBus)).WithServiceAllInterfaces());
            container.Register(Classes.FromThisAssembly().Pick().WithServiceAllInterfaces().LifestyleTransient());

        }
    }
}
