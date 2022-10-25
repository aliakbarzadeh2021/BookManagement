
using Topshelf;

namespace ServiceHost.ServiceHost
{
    public class ServiceHostFactory
    {
        public static void Run()
        {
            HostFactory.Run(configurator =>
            {
                configurator.SetServiceName("RESTApiService");
                configurator.SetDisplayName("REST Api Service");
                configurator.SetDescription("Service for Book Management");
                configurator.RunAsLocalService();
                configurator.Service<ServiceHost>(hostSettings =>
                {
                    hostSettings.ConstructUsing(builder => new ServiceHost());
                    hostSettings.WhenStarted(service => service.Start());
                    hostSettings.WhenStopped(service => service.Stop());
                });
            });
        }
    }
}
