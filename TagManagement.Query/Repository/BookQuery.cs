using System;
using System.Collections.Generic;
using TagManagement.Repository;

namespace TagManagement.Query.Repository
{
    public class BookQuery<TBookDto>
    {
        private readonly IBookQueryRepository<TBookDto,Guid> _bookQueryRepository;

        public BookQuery(IBookQueryRepository<TBookDto,Guid> bookQueryRepository)
        {
            _bookQueryRepository = bookQueryRepository;
        }

        public TBookDto SelectById(Guid id)
        {
            return _bookQueryRepository.SelectById(id);
        }

        public IEnumerable<TBookDto> SearchFor()
        {
            return _bookQueryRepository.SearchFor();
        }

        public IEnumerable<TBookDto> GetAll()
        {
            return _bookQueryRepository.GetAll();
        }
    }
}
