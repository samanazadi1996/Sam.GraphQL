using GraphQL.Types;
using Sam.GraphQL.Entities;

namespace Sam.GraphQL.GraphQLTypes
{
    public class GraphQLProductType : ObjectGraphType<Product>
    {
        public GraphQLProductType()
        {
            Field(c => c.Id);
            Field(c => c.Name);
            Field(c => c.Price);
            Field(c => c.Barcode);
            Field(c => c.InsertDateTime);
            Field(c => c.Count);
        }

    }
}
