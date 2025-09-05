using BookStore.Domain.Entities;

namespace BookStore.Domain.Repositories;

public interface IOrderRepository
{
    IQueryable<Order> Query();
    Task AddAsync(Order entity, CancellationToken ct = default);
    // (others as needed)
}
