using Logic.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Poke_Connector.Models.Dtos;

namespace Logic.DatabaseContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<PokemonDbDto> Pokemons => Set<PokemonDbDto>();

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PokeTableConfiguration());
        }
    }
}

