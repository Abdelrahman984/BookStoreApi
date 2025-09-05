namespace BookStore.Application.DTOs.Order
{
    public class OrderCreateDto
    {
        public CustomerInfoDto Customer { get; set; } = new();
        public decimal Total { get; set; }
        public List<OrderItemDto> Items { get; set; } = new();
    }
}
