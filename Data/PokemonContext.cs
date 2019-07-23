using GraphQLPlayground.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLPlayground.Data
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> contextOptions)
            : base(contextOptions)
        { }

        internal DbSet<Pokemon> Pokemon { get; set; }
        internal DbSet<PokemonType> PokemonTypes { get; set; }
        internal DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonType>().HasKey(pt => new { pt.PokemonId, pt.TypeId });
            modelBuilder.Entity<Pokemon>()
                .HasMany(p => p.PokemonTypes)
                .WithOne()
                .HasForeignKey(pt => pt.PokemonId);
            modelBuilder.Entity<Type>()
                .HasMany(t => t.PokemonTypes)
                .WithOne()
                .HasForeignKey(pt => pt.TypeId);

            modelBuilder.Entity<Type>().HasGenOneTypes();
            modelBuilder.Entity<Pokemon>().HasGenOnePokemon();
            modelBuilder.Entity<PokemonType>().HasGenOnePokemonTypes();
        }
    }
}
