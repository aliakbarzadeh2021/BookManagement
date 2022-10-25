using System;

namespace Infrastructure.CommandClass
{
    public interface ICommand
    {
        Guid Id { get; }
    }

    public class Command : ICommand
    {
        public Guid Id { get; set; }
    }

    public interface ICommandHandler<in T> // where T : class
    {
        void Handle(T command);
    }

    public class CommandHandler<T> : ICommandHandler<T> // where T : class
    {
        public void Handle(T command)
        {
             
        }
    }
}
