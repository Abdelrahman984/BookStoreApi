using AutoMapper;
using BookStore.Application.DTOs;
using BookStore.Application.DTOs.Order;
using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;
using BookStore.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Application.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orders;
    private readonly IBookRepository _books;
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository orders, IBookRepository books, IUnitOfWork uow, IMapper mapper)
    {
        _orders = orders;
        _books = books;
        _uow = uow;
        _mapper = mapper;
    }

    public async Task<Guid> CreateAsync(OrderCreateDto dto, CancellationToken ct = default)
    {
        // ✅ تحقق إن كل الكتب موجودة
        var bookIds = dto.Items.Select(i => i.BookId).ToList();
        var existingBookIds = await _books.GetExistingBookIdsAsync(bookIds, ct);

        if (existingBookIds.Count != bookIds.Count)
        {
            throw new InvalidOperationException("One or more books in the order do not exist.");
        }

        // ✅ عمل Map للـ DTO → Entity
        var entity = _mapper.Map<Order>(dto);
        entity.CreatedAt = DateTime.UtcNow;

        await _orders.AddAsync(entity, ct);
        await _uow.SaveChangesAsync(ct);

        return entity.Id;
    }

    public async Task<OrderReadDto?> GetByIdAsync(Guid id, CancellationToken ct = default)
    {
        var query = _orders.Query()
            .Include(o => o.Items)
            .ThenInclude(i => i.Book)
            .Include(o => o.CustomerInfo)
            .Where(o => o.Id == id);

        return await query
            .Select(o => new OrderReadDto
            {
                Id = o.Id,
                Total = o.Total,
                CreatedAt = o.CreatedAt,
                Customer = new CustomerInfoDto
                {
                    Name = o.CustomerInfo.Name,
                    Email = o.CustomerInfo.Email,
                    Address = o.CustomerInfo.Address
                },
                Items = o.Items.Select(i => new OrderItemDto
                {
                    BookId = i.BookId,
                    BookTitle = i.Book.Title,
                    Quantity = i.Quantity,
                    Price = i.Price
                }).ToList()
            })
            .FirstOrDefaultAsync(ct);
    }

    public async Task<IReadOnlyList<OrderSummaryDto>> GetAllAsync(CancellationToken ct = default)
    {
        var query = _orders.Query()
            .Include(o => o.CustomerInfo)
            .OrderByDescending(o => o.CreatedAt);

        return await query
            .Select(o => new OrderSummaryDto
            {
                Id = o.Id,
                CustomerName = o.CustomerInfo.Name,
                CustomerEmail = o.CustomerInfo.Email,
                Total = o.Total,
                CreatedAt = o.CreatedAt
            })
            .ToListAsync(ct);
    }
}
