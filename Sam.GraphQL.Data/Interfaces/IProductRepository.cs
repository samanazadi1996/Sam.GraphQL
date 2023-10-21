using Sam.GraphQL.Entities;

namespace Sam.GraphQL.Data.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAll();
    }
}
