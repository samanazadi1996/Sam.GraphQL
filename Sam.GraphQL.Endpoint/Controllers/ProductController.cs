using Microsoft.AspNetCore.Mvc;
using Sam.GraphQL.Data.Interfaces;
using Sam.GraphQL.Entities;

namespace Sam.GraphQL.Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    private readonly IProductRepository productRepository;

    public ProductController(IProductRepository productRepository)
    {
        this.productRepository = productRepository;
    }

    [HttpGet(Name = "GetAll")]
    public IEnumerable<Product> GetAll()
    {
        return productRepository.GetAll();
    }
}
