namespace BookStore.Application.DTOs.Book
{
    public class BookUpdateDto
    {
        public string Title { get; set; } = default!;
        public string Author { get; set; } = default!;
        public decimal Price { get; set; }
        public string? CoverImage { get; set; }
        public string? Description { get; set; }
        public string? ISBN { get; set; }
        public string? Genre { get; set; }
        public DateTime? PublicationDate { get; set; }
        public int Stock { get; set; } = 0;
    }
}
