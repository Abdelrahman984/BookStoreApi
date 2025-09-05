using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Persistence
{
    public static class BookSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    Price = 10.99m,
                    CoverImage = "https://covers.openlibrary.org/b/id/7222246-L.jpg",
                    Description = "A novel about the American dream and its downfall.",
                    ISBN = "9780743273565",
                    Genre = "Classic",
                    PublicationDate = new DateTime(1925, 4, 10),
                    Stock = 50
                },
                new Book
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Title = "1984",
                    Author = "George Orwell",
                    Price = 9.99m,
                    CoverImage = "https://covers.openlibrary.org/b/id/7222246-L.jpg",
                    Description = "Dystopian novel set in a totalitarian society.",
                    ISBN = "9780451524935",
                    Genre = "Dystopian",
                    PublicationDate = new DateTime(1949, 6, 8),
                    Stock = 40
                },
                new Book
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Price = 12.99m,
                    CoverImage = "https://covers.openlibrary.org/b/id/8228691-L.jpg",
                    Description = "A novel about racial injustice in the Deep South.",
                    ISBN = "9780061120084",
                    Genre = "Classic",
                    PublicationDate = new DateTime(1960, 7, 11),
                    Stock = 60
                },
                new Book
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Price = 8.99m,
                    CoverImage = "https://covers.openlibrary.org/b/id/8091016-L.jpg",
                    Description = "A romantic novel of manners.",
                    ISBN = "9780141439518",
                    Genre = "Romance",
                    PublicationDate = new DateTime(1813, 1, 28),
                    Stock = 30
                },
                new Book
                {
                    Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    Title = "Moby-Dick",
                    Author = "Herman Melville",
                    Price = 11.50m,
                    CoverImage = "https://covers.openlibrary.org/b/id/5552222-L.jpg",
                    Description = "The saga of Captain Ahab’s obsessive quest.",
                    ISBN = "9781503280786",
                    Genre = "Adventure",
                    PublicationDate = new DateTime(1851, 10, 18),
                    Stock = 20
                },
                new Book
                {
                    Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    Title = "War and Peace",
                    Author = "Leo Tolstoy",
                    Price = 14.99m,
                    CoverImage = "https://covers.openlibrary.org/b/id/7222161-L.jpg",
                    Description = "A historical novel set during the Napoleonic Wars.",
                    ISBN = "9780199232765",
                    Genre = "Historical",
                    PublicationDate = new DateTime(1869, 1, 1),
                    Stock = 25
                },
                new Book
                {
                    Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    Price = 9.50m,
                    CoverImage = "https://covers.openlibrary.org/b/id/8231856-L.jpg",
                    Description = "A story about teenage rebellion and angst.",
                    ISBN = "9780316769488",
                    Genre = "Classic",
                    PublicationDate = new DateTime(1951, 7, 16),
                    Stock = 45
                },
                new Book
                {
                    Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    Price = 10.25m,
                    CoverImage = "https://covers.openlibrary.org/b/id/7222246-L.jpg",
                    Description = "A futuristic society driven by technology and control.",
                    ISBN = "9780060850524",
                    Genre = "Dystopian",
                    PublicationDate = new DateTime(1932, 8, 31),
                    Stock = 35
                },
                new Book
                {
                    Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    Price = 13.99m,
                    CoverImage = "https://covers.openlibrary.org/b/id/6979861-L.jpg",
                    Description = "A fantasy adventure before The Lord of the Rings.",
                    ISBN = "9780547928227",
                    Genre = "Fantasy",
                    PublicationDate = new DateTime(1937, 9, 21),
                    Stock = 70
                },
                new Book
                {
                    Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    Title = "The Fellowship of the Ring",
                    Author = "J.R.R. Tolkien",
                    Price = 14.50m,
                    CoverImage = "https://covers.openlibrary.org/b/id/7898781-L.jpg",
                    Description = "The first volume of The Lord of the Rings.",
                    ISBN = "9780547928210",
                    Genre = "Fantasy",
                    PublicationDate = new DateTime(1954, 7, 29),
                    Stock = 65
                },
                new Book
                {
                    Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                    Title = "Harry Potter and the Philosopher's Stone",
                    Author = "J.K. Rowling",
                    Price = 15.99m,
                    CoverImage = "https://covers.openlibrary.org/b/id/7984916-L.jpg",
                    Description = "The first book in the Harry Potter series.",
                    ISBN = "9780747532699",
                    Genre = "Fantasy",
                    PublicationDate = new DateTime(1997, 6, 26),
                    Stock = 100
                },
                new Book
                {
                    Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                    Title = "The Da Vinci Code",
                    Author = "Dan Brown",
                    Price = 12.75m,
                    CoverImage = "https://covers.openlibrary.org/b/id/240726-L.jpg",
                    Description = "A mystery thriller exploring symbology and history.",
                    ISBN = "9780307474278",
                    Genre = "Thriller",
                    PublicationDate = new DateTime(2003, 3, 18),
                    Stock = 55
                },
                new Book
                {
                    Id = Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    Price = 9.99m,
                    CoverImage = "https://covers.openlibrary.org/b/id/7884861-L.jpg",
                    Description = "A novel about pursuing dreams and destiny.",
                    ISBN = "9780061122415",
                    Genre = "Philosophical",
                    PublicationDate = new DateTime(1988, 5, 1),
                    Stock = 80
                },
                new Book
                {
                    Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                    Title = "The Kite Runner",
                    Author = "Khaled Hosseini",
                    Price = 11.99m,
                    CoverImage = "https://covers.openlibrary.org/b/id/240727-L.jpg",
                    Description = "A story of friendship and redemption in Afghanistan.",
                    ISBN = "9781594631931",
                    Genre = "Drama",
                    PublicationDate = new DateTime(2003, 5, 29),
                    Stock = 50
                },
                new Book
                {
                    Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                    Title = "The Road",
                    Author = "Cormac McCarthy",
                    Price = 10.50m,
                    CoverImage = "https://covers.openlibrary.org/b/id/240728-L.jpg",
                    Description = "A bleak post-apocalyptic tale of survival.",
                    ISBN = "9780307387899",
                    Genre = "Post-apocalyptic",
                    PublicationDate = new DateTime(2006, 9, 26),
                    Stock = 25
                }
            );
        }
    }
}
