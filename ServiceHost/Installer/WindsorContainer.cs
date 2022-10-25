using Castle.Windsor;

namespace ServiceHost.Installer
{
    public class DependencyContainer
    {
        public static IWindsorContainer Container { get; private set; }

        public DependencyContainer()
        {
            Container = new WindsorContainer();
        }

        public void Start()
        {
            Container.Install(new ServiceInstaller());
        }
        public static void Stop()
        {
            Container.Dispose();
        }
    }
}
