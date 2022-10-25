using System;
using System.Linq;
using System.Reflection;
using Infrastructure.CommandClass;
using TagManagement.Command.Installer;

namespace TagManagement.Command.CommandBus
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : ICommand;
    }

    public class CommandBus : ICommandBus
    {
        public void Send<T>(T command) where T : ICommand
        {
            var commandHandler = (ICommandHandler<T>)CommandServiceInstaller.Container.Resolve(typeof(ICommandHandler<T>));
            commandHandler.Handle(command);
        }

        private ICommandHandler<T> CreateInstanceCommandHandler<T>(T command)
        {
            var commandType = command.GetType();
            var assembly = Assembly.GetExecutingAssembly();
            var handlers = assembly.GetTypes().Where(x => x.IsClass && x.Name.Contains("CommandHandler"));

            foreach (var handler in handlers)
            {
                var i = (ICommandHandler<T>)CommandServiceInstaller.Container.Resolve(typeof(ICommandHandler<T>));
                //var item = (ICommandHandler<T>)Activator.CreateInstance(handler);
                i.Handle(command);
                return i;
            }
            return null;
        }
    }
}
