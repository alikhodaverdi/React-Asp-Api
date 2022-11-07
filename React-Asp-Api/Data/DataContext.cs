﻿using Microsoft.EntityFrameworkCore;
using React_Asp_Api.Models;

namespace React_Asp_Api.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }

        public DbSet<PokemonOwner> PokemonOwners { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                .HasKey(pc => new {pc.PokemonId,pc.CategoryId});
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc=>pc.PokemonCategories)
                .HasForeignKey(c=>c.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
              .HasOne(p => p.Category)
              .WithMany(pc => pc.PokemonCategories)
              .HasForeignKey(c => c.CategoryId);

        }



    }
}