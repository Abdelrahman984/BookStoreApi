namespace BookStore.Api.Extensions
{
    public static class CorsServiceExtensions
    {
        public static IServiceCollection AddCorsPolicy(this IServiceCollection services, IConfiguration config)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowFrontend", policy =>
                {
                    policy.WithOrigins("https://book-store-mocha-phi.vercel.app")
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
            });

            return services;
        }
    }
}
