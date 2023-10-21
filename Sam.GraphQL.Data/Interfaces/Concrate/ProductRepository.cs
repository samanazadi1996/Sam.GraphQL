using Sam.GraphQL.Entities;

namespace Sam.GraphQL.Data.Interfaces.Concrate
{
    internal class ProductRepository : IProductRepository
    {
        public IQueryable<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            // Generate 50 products using a for loop
            for (int i = 1; i <= 50; i++)
            {
                Product product = new Product
                {
                    Id = i,
                    Name = $"Product {i}",
                    Price = 19.99 + (i * 0.5), // Adjust the price incrementally for each product
                    Barcode = $"ABC{i}123",
                    InsertDateTime = DateTime.Now,
                    Count = 100 + i // Adjust the count incrementally for each product
                };

                products.Add(product);
            }

            return products.AsQueryable();
        }
    }
}
