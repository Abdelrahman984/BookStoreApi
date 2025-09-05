using AutoMapper;
using BookStore.Application.DTOs;
using BookStore.Application.DTOs.Book;
using BookStore.Application.DTOs.Order;
using BookStore.Domain.Entities;

namespace BookStore.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Book, BookReadDto>();
        CreateMap<BookCreateDto, Book>();
        CreateMap<BookUpdateDto, Book>();

        // From Create DTOs → Entities
        CreateMap<OrderCreateDto, Order>()
            .ForMember(d => d.CustomerInfo, opt => opt.MapFrom(s => s.Customer))
            .ForMember(d => d.Items, opt => opt.MapFrom(s => s.Items));

        CreateMap<CustomerInfoDto, CustomerInfo>();

        CreateMap<OrderItemDto, OrderItem>();

        // If you also want to support read DTOs (optional)
        CreateMap<Order, OrderReadDto>()
            .ForMember(d => d.Customer, opt => opt.MapFrom(s => s.CustomerInfo))
            .ForMember(d => d.Items, opt => opt.MapFrom(s => s.Items));

        CreateMap<OrderItem, OrderItemReadDto>()
            .ForMember(d => d.BookTitle, opt => opt.MapFrom(s => s.Book.Title));

        CreateMap<CustomerInfo, CustomerInfoDto>();

        CreateMap<Order, OrderSummaryDto>()
            .ForMember(d => d.CustomerName, opt => opt.MapFrom(s => s.CustomerInfo.Name))
            .ForMember(d => d.CustomerEmail, opt => opt.MapFrom(s => s.CustomerInfo.Email));


    }
}