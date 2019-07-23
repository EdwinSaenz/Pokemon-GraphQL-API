using System.Collections.Generic;
using System.Linq;
using GraphQLPlayground.Core.Data;
using GraphQLPlayground.Core.Models;

namespace GraphQLPlayground.Data.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonContext context;

        public PokemonRepository(PokemonContext context) => this.context = context;

        public IEnumerable<Pokemon> GetAll() =>
            from p in context.Pokemon
            join pt in context.PokemonTypes on p.Id equals pt.PokemonId
            join t in context.Types on pt.TypeId equals t.Id
            group new { Pokemon = p, Type = t } by p into g
            select new Core.Models.Pokemon
            {
                Id = g.Key.Id,
                Name = g.Key.Name,
                Types = g
                    .Select(pt => new Core.Models.Type
                    {
                        Id = pt.Type.Id,
                        Name = pt.Type.Name
                    })
                    .ToList()
            };

        public Pokemon GetById(int id) => GetAll().FirstOrDefault(p => p.Id == id);
    }
}