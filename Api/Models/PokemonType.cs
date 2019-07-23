using GraphQL.Types;
using GraphQLPlayground.Core.Models;

namespace GraphQLPlayground.Api.Models
{
    public class PokemonType : ObjectGraphType<Pokemon>
    {
        public PokemonType()
        {
            Name = "Pokemon";

            Field(p => p.Id).Description("National Dex number");
            Field(p => p.Name).Description("Pokémon name");
            Field(
                name: "Types",
                description: "The type(s) of the Pokémon",
                type: typeof(ListGraphType<TypeType>),
                resolve: context => context.Source.Types);
        }
    }
}