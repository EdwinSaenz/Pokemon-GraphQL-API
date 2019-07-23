using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace GraphQLPlayground.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<PokemonContext>
    {
        public PokemonContext CreateDbContext(string[] args)
        {
            var dbContextBuilder = new DbContextOptionsBuilder<PokemonContext>();
            dbContextBuilder.UseSqlite("Data Source=pokemon.db");
            
            return new PokemonContext(dbContextBuilder.Options);
        }
    }
}