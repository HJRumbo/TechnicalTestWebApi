using DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TechnicalTestWebApi.Middlewares;

namespace TechnicalTestWebApi.Extensions
{
    public static class ApplicationExtensions
    {
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }

        public static IServiceCollection AddPresentationLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            var connectionString = configuration.GetConnectionString("ConnectionString");
            services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString));

            return services;
        }
    }
}
