using System.Collections.Generic;
using GraphQLPlayground.Core.Models;

namespace GraphQLPlayground.Core.Data
{
    public interface IPokemonRepository
    {
        Pokemon GetById(int id);
        IEnumerable<Pokemon> GetAll();
    }
}