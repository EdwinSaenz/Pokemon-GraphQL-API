using GraphQL;
using GraphQL.Types;

namespace GraphQLPlayground.Api.Models
{
    public class PokemonSchema : Schema
    {
        public PokemonSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<PokemonQuery>();
        }
    }
}