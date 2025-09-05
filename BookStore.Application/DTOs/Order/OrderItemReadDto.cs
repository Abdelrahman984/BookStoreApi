namespace BookStore.Application.DTOs.Order
{
    public class OrderItemReadDto
    {
        public Guid BookId { get; set; }
        public string BookTitle { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
