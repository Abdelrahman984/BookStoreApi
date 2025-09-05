using BookStore.Domain.Entities;
using BookStore.Domain.Repositories;
using BookStore.Infrastructure.Persistence;

public class OrderRepository : IOrderRepository
{
    private readonly AppDbContext _ctx;
    public OrderRepository(AppDbContext ctx) => _ctx = ctx;

    public IQueryable<Order> Query() => _ctx.Orders.AsQueryable();

    public async Task AddAsync(Order entity, CancellationToken ct = default)
        => await _ctx.Orders.AddAsync(entity, ct);
}
