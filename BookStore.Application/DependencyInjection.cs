using BookStore.Application.Interfaces;
using BookStore.Application.Mapping;
using BookStore.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile).Assembly);
        services.AddTransient<IBookService, BookService>();
        services.AddTransient<IOrderService, OrderService>();


        return services;
    }
}

