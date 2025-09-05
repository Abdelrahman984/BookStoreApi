namespace BookStore.Application.DTOs.Order
{
    public class OrderItemDto
    {
        public Guid BookId { get; set; }
        public string BookTitle { get; set; } = string.Empty; // optional, handy for UI
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
