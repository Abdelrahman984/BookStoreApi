using BookStore.Application.DTOs.Order;

namespace BookStore.Application.Interfaces
{
    public interface IOrderService
    {
        Task<Guid> CreateAsync(OrderCreateDto dto, CancellationToken ct = default);
        Task<OrderReadDto?> GetByIdAsync(Guid id, CancellationToken ct = default);
        Task<IReadOnlyList<OrderSummaryDto>> GetAllAsync(CancellationToken ct = default);
    }
}
