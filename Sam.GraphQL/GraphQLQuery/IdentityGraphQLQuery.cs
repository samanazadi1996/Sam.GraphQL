using GraphQL.Types;
using Sam.GraphQL.Data.Interfaces;
using Sam.GraphQL.GraphQLTypes;
using Sam.GraphQL.Shared;

namespace Sam.GraphQL.GraphQLQuery
{
    public class IdentityGraphQLQuery : ObjectGraphType
    {
        public IdentityGraphQLQuery(IProductRepository productRepository)
        {
            var products = productRepository.GetAll();
            Field<ListGraphType<GraphQLProductType>>(name: ServiceNames.Products, resolve: context => products);
        }
    }
}
