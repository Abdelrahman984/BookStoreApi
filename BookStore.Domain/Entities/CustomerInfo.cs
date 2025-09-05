namespace BookStore.Domain.Entities;

public class CustomerInfo
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;

    public Guid OrderId { get; set; }
    public Order Order { get; set; } = null!;
}
