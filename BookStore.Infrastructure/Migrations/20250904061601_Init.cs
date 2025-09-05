using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerInfos_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImage", "Description", "Genre", "ISBN", "Price", "PublicationDate", "Stock", "Title" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "F. Scott Fitzgerald", "https://covers.openlibrary.org/b/id/7222246-L.jpg", "A novel about the American dream and its downfall.", "Classic", "9780743273565", 10.99m, new DateTime(1925, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "The Great Gatsby" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "George Orwell", "https://covers.openlibrary.org/b/id/7222246-L.jpg", "Dystopian novel set in a totalitarian society.", "Dystopian", "9780451524935", 9.99m, new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "1984" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Harper Lee", "https://covers.openlibrary.org/b/id/8228691-L.jpg", "A novel about racial injustice in the Deep South.", "Classic", "9780061120084", 12.99m, new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, "To Kill a Mockingbird" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Jane Austen", "https://covers.openlibrary.org/b/id/8091016-L.jpg", "A romantic novel of manners.", "Romance", "9780141439518", 8.99m, new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Pride and Prejudice" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Herman Melville", "https://covers.openlibrary.org/b/id/5552222-L.jpg", "The saga of Captain Ahab’s obsessive quest.", "Adventure", "9781503280786", 11.50m, new DateTime(1851, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Moby-Dick" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Leo Tolstoy", "https://covers.openlibrary.org/b/id/7222161-L.jpg", "A historical novel set during the Napoleonic Wars.", "Historical", "9780199232765", 14.99m, new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "War and Peace" },
                    { new Guid("77777777-7777-7777-7777-777777777777"), "J.D. Salinger", "https://covers.openlibrary.org/b/id/8231856-L.jpg", "A story about teenage rebellion and angst.", "Classic", "9780316769488", 9.50m, new DateTime(1951, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "The Catcher in the Rye" },
                    { new Guid("88888888-8888-8888-8888-888888888888"), "Aldous Huxley", "https://covers.openlibrary.org/b/id/7222246-L.jpg", "A futuristic society driven by technology and control.", "Dystopian", "9780060850524", 10.25m, new DateTime(1932, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, "Brave New World" },
                    { new Guid("99999999-9999-9999-9999-999999999999"), "J.R.R. Tolkien", "https://covers.openlibrary.org/b/id/6979861-L.jpg", "A fantasy adventure before The Lord of the Rings.", "Fantasy", "9780547928227", 13.99m, new DateTime(1937, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, "The Hobbit" },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "J.R.R. Tolkien", "https://covers.openlibrary.org/b/id/7898781-L.jpg", "The first volume of The Lord of the Rings.", "Fantasy", "9780547928210", 14.50m, new DateTime(1954, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, "The Fellowship of the Ring" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "J.K. Rowling", "https://covers.openlibrary.org/b/id/7984916-L.jpg", "The first book in the Harry Potter series.", "Fantasy", "9780747532699", 15.99m, new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, "Harry Potter and the Philosopher's Stone" },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "Dan Brown", "https://covers.openlibrary.org/b/id/240726-L.jpg", "A mystery thriller exploring symbology and history.", "Thriller", "9780307474278", 12.75m, new DateTime(2003, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, "The Da Vinci Code" },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), "Paulo Coelho", "https://covers.openlibrary.org/b/id/7884861-L.jpg", "A novel about pursuing dreams and destiny.", "Philosophical", "9780061122415", 9.99m, new DateTime(1988, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, "The Alchemist" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), "Khaled Hosseini", "https://covers.openlibrary.org/b/id/240727-L.jpg", "A story of friendship and redemption in Afghanistan.", "Drama", "9781594631931", 11.99m, new DateTime(2003, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "The Kite Runner" },
                    { new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"), "Cormac McCarthy", "https://covers.openlibrary.org/b/id/240728-L.jpg", "A bleak post-apocalyptic tale of survival.", "Post-apocalyptic", "9780307387899", 10.50m, new DateTime(2006, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "The Road" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInfos_OrderId",
                table: "CustomerInfos",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_BookId",
                table: "OrderItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerInfos");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
