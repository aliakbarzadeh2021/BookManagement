using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TagManagement.Command.Commands;
using TagManagement.Query.Dto;
using TagManagement.Query.Repository;
using TagManagement.Command.CommandBus;
using TagManagement.Command.CommandHandlers;

namespace ServiceHost.Controller
{
    public class BooksController : ApiController
    {
        private readonly ICommandBus _bus;
        private readonly BookQuery<BookDto> _bookQuery;

        public BooksController(ICommandBus bus, BookQuery<BookDto> bookQuery)
        {
            this._bus = bus;
            _bookQuery = bookQuery;
        }

        public IEnumerable<BookDto> Get()
        {
            return _bookQuery.GetAll();
        }
        public BookDto Get(Guid id)
        {
            return _bookQuery.SelectById(id);
        }
        public void Post(string value)
        {
            var command = new CreateBookCommand();
            _bus.Send(command);
        }

        public void Put(int id , string value)
        {
            var command = new UpdateBookCommand();
            _bus.Send(command);
        }
        public void Delete(int id)
        {
            var command = new DeleteBookCommand();
            _bus.Send(command);
        }
    }
}
