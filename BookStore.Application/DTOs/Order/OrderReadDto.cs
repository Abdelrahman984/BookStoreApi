namespace BookStore.Application.DTOs.Order
{
    public class OrderReadDto
    {
        public Guid Id { get; set; }
        public CustomerInfoDto Customer { get; set; } = new();
        public decimal Total { get; set; }
        public List<OrderItemDto> Items { get; set; } = new();
        public DateTime CreatedAt { get; set; }
    }
}
