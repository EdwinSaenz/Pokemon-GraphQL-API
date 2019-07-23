using System.Collections.Generic;

namespace GraphQLPlayground.Data.Models
{
    internal class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PokemonType> PokemonTypes { get; set; }
    }
}