using Infrastructure.Repository;

namespace TagManagement.Repository
{
    public interface IBookQueryRepository<out T, in TId> : IQueryRepository<T,TId>
    {
    }

    public class BookQueryRepository<T, TId> : EntityFrameworkRepository<T, TId> ,IBookQueryRepository<T, TId>
    {
        
    }
}
