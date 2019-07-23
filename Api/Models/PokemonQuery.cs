using GraphQL.Types;
using GraphQLPlayground.Api.Helpers;

namespace GraphQLPlayground.Api.Models
{
    public class PokemonQuery : ObjectGraphType
    {
        public PokemonQuery(ContextServiceLocator contextServiceLocator)
        {
            Field<PokemonType>(
                "Pokemon",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return contextServiceLocator.PokemonRepository.GetById(id);
                });

            Field<ListGraphType<PokemonType>>(
                "AllPokemon",
                resolve: context =>
                {
                    return contextServiceLocator.PokemonRepository.GetAll();
                });
        }
    }
}