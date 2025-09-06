# BookStore API

Backend API for the Book Store project built with .NET Core 9 using Clean Architecture and MS SQL Server.

## Features

* CRUD operations for books
* Place and manage orders
* MS SQL Server database with seeded data
* DTOs and AutoMapper for data transfer
* CORS enabled for frontend communication

## Tech Stack

* .NET Core 9
* Clean Architecture
* Entity Framework Core
* MS SQL Server
* AutoMapper & DTOs

## API Endpoints

### Books

* `GET /api/books` - Retrieve all books
* `GET /api/books/{id}` - Retrieve a single book by ID
* `POST /api/books` - Create a new book
* `PUT /api/books/{id}` - Update an existing book
* `DELETE /api/books/{id}` - Delete a book

### Orders

* `POST /api/orders` - Create a new order
* `GET /api/orders/{id}` - Retrieve a single order by ID
* `GET /api/orders` - Retrieve all orders

## Setup

1. Clone the repository:

```bash
git clone https://github.com/Abdelrahman984/BookStoreApi.git
```

2. Configure your MS SQL Server connection in `appsettings.json` or User Secrets:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=BookStoreDb;User Id=your_username;Password=your_password;TrustServerCertificate=True"
}
```

3. Apply migrations and seed the database:

```bash
dotnet ef database update
```

4. Run the API:

```bash
dotnet run --project CleanArchitecture.Api
```

## Deployment

* Hosted on Monster Asp.Net: [BookStore API](https://bookrstoreapi.runasp.net)
* Ensure frontend `VITE_API_URL` points to this URL.

## Contributing

Contributions are welcome! Please submit pull requests for bug fixes or feature improvements.

## License

This project is open-source and available under the MIT License.
