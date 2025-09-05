using AutoMapper;
using BookStore.Application.DTOs.Book;
using BookStore.Application.Interfaces;
using BookStore.Domain.Entities;
using BookStore.Domain.Repositories;

namespace BookStore.Application.Services;

public class BookService : IBookService
{
    private readonly IUnitOfWork _uow;
    private readonly IMapper _mapper;

    public BookService(IUnitOfWork uow, IMapper mapper)
    {
        _uow = uow;
        _mapper = mapper;
    }

    public async Task<Guid> CreateAsync(BookCreateDto dto)
    {
        var entity = _mapper.Map<Book>(dto);
        await _uow.Books.AddAsync(entity);
        await _uow.CommitAsync();
        return entity.Id;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var existing = await _uow.Books.GetByIdAsync(id);
        if (existing == null) return false;
        _uow.Books.Delete(existing);
        await _uow.CommitAsync();
        return true;
    }

    public async Task<IEnumerable<BookReadDto>> GetAllAsync()
    {
        var all = await _uow.Books.GetAllAsync();
        return _mapper.Map<IEnumerable<BookReadDto>>(all);
    }

    public async Task<BookReadDto?> GetByIdAsync(Guid id)
    {
        var e = await _uow.Books.GetByIdAsync(id);
        return e == null ? null : _mapper.Map<BookReadDto>(e);
    }

    public async Task<bool> UpdateAsync(Guid id, BookUpdateDto dto)
    {
        var existing = await _uow.Books.GetByIdAsync(id);
        if (existing == null) return false;
        _mapper.Map(dto, existing);
        _uow.Books.Update(existing);
        await _uow.CommitAsync();
        return true;
    }
}