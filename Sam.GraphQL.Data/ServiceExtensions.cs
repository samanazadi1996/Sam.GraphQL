using Microsoft.Extensions.DependencyInjection;
using Sam.GraphQL.Data.Interfaces;
using Sam.GraphQL.Data.Interfaces.Concrate;

namespace Sam.GraphQL.Data
{
    public static class ServiceExtensions
    {
        public static void AddDAL(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
