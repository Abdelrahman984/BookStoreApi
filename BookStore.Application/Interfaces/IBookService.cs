using BookStore.Application.DTOs.Book;

namespace BookStore.Application.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookReadDto>> GetAllAsync();
        Task<BookReadDto?> GetByIdAsync(Guid id);
        Task<Guid> CreateAsync(BookCreateDto dto);
        Task<bool> UpdateAsync(Guid id, BookUpdateDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
