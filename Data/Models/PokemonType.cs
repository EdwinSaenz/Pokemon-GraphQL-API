namespace GraphQLPlayground.Data.Models
{
    internal class PokemonType
    {
        public int PokemonId { get; set; }
        public int TypeId { get; set; }

        public Pokemon Pokemon { get; set; }
        public Type Type { get; set; }
    }
}