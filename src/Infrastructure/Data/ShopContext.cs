﻿using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // https://www.learnentityframeworkcore.com/configuration/fluent-api
            // modelBuilder.ApplyConfiguration(new CategoryConfiguration());   // Tekil hali, her model icin ayrı ayrı uygulanır.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  // tara ve configuration dosyalarını bul
        }
    }
}
