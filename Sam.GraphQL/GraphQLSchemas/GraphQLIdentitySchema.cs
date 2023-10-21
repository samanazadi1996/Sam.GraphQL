using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using Sam.GraphQL.GraphQLQuery;

namespace Sam.GraphQL.GraphQLSchemas
{
    public class GraphQLIdentitySchema : Schema
    {
        public GraphQLIdentitySchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<IdentityGraphQLQuery>();
        }
    }
}
