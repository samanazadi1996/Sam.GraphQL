using GraphQL;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Sam.GraphQL.GraphQLQuery;
using Sam.GraphQL.GraphQLSchemas;
using Sam.GraphQL.GraphQLTypes;

namespace Sam.GraphQL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddGraphQLInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ISchema, GraphQLIdentitySchema>();

            services.AddScoped<IdentityGraphQLQuery>();

            services.AddScoped<GraphQLProductType>();

            services.AddGraphQL(p =>
            {
                p.AddSystemTextJson();
            });

            return services;
        }

        public static IApplicationBuilder UseGraphQLInfrastructure(this IApplicationBuilder app,string url)
        {
            app.UseGraphQL<ISchema>("/graphql");

            var op = new PlaygroundOptions();

            op.Headers ??= new Dictionary<string, object>();
            op.Headers.Add("Authorization", "bearer token");

            app.UseGraphQLPlayground(url, op);

            return app;
        }
    }
}