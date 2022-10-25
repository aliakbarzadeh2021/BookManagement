
using ServiceHost.Controller;
using ServiceHost.ServiceHost;
using TagManagement.Command.CommandHandlers;

namespace ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHostFactory.Run();
        }
    }
}
