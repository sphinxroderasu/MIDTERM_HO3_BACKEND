using Microsoft.EntityFrameworkCore;
using PokemonApi.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PokemonApi.Data
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options)
        {
        }
        public DbSet<Pokemon> Pokemon { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

         
        }
    }
}