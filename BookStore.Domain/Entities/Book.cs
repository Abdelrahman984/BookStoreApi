namespace BookStore.Domain.Entities
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public decimal Price { get; set; }

        // Optional properties
        public string? CoverImage { get; set; }
        public string? Description { get; set; }
        public string? ISBN { get; set; }
        public string? Genre { get; set; }
        public DateTime? PublicationDate { get; set; }
        public int Stock { get; set; } = 0;
    }
}
