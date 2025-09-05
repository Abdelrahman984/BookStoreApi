namespace BookStore.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        Task<int> CompleteAsync();
        Task<int> CommitAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
