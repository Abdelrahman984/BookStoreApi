using BookStore.Domain.Entities;

namespace BookStore.Domain.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllAsync();
        Task<Book?> GetByIdAsync(Guid id);
        Task AddAsync(Book book);
        void Update(Book book);
        void Delete(Book book);
        IQueryable<Book> Query();
        Task<List<Guid>> GetExistingBookIdsAsync(IEnumerable<Guid> ids, CancellationToken ct = default);

    }
}
