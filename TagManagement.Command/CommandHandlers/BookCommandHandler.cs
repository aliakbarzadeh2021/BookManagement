using Infrastructure.CommandClass;
using TagManagement.Command.Commands;
using TagManagement.Domain.Interface;
using TagManagement.Domain.Model.BookAggregate;

namespace TagManagement.Command.CommandHandlers
{
    public class BookCommandHandler :
        ICommandHandler<CreateBookCommand>,
        ICommandHandler<DeleteBookCommand>,
        ICommandHandler<UpdateBookCommand>
    {
        private readonly IBookRepository _bookRepository;

        public BookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Handle(CreateBookCommand command)
        {
            var book = new Book();
            _bookRepository.Insert(book);
        }

        public void Handle(DeleteBookCommand command)
        {
            _bookRepository.Remove(command.Id);
        }

        public void Handle(UpdateBookCommand command)
        {
            //_bookRepository.Update(command);
        }
    }
}
