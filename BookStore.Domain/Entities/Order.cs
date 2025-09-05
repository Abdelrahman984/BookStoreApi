namespace BookStore.Domain.Entities;

public class Order
{
    public Guid Id { get; set; }
    public Guid CustomerInfoId { get; set; }
    public CustomerInfo CustomerInfo { get; set; } = null!;
    public decimal Total { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
}
