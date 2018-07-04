using DbContexts.AdConfigurations;
using Microsoft.EntityFrameworkCore;
using Models.Ad.Entities;
using System;

namespace DbContexts
{
    //https://github.com/damienbod/AspNetCoreMultipleProject/blob/master/src/DataAccessMsSqlServerProvider/DomainModelMsSqlServerContext.cs
    //http://www.entityframeworktutorial.net/code-first/configure-one-to-one-relationship-in-code-first.aspx
    public class AdDbContext : DbContext
    {
        public AdDbContext(DbContextOptions<AdDbContext> options) : base(options)
        {
        }

        public static AdDbContext Create(string connection = "Server=localhost;Database=Ad;Trusted_Connection=True;")
        {
            if (string.IsNullOrEmpty(connection)) throw new ArgumentNullException(nameof(connection));
            return new AdDbContext(new DbContextOptionsBuilder<AdDbContext>().UseSqlServer(connection).Options);
        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<Asset> AdAssets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdConfig());
            modelBuilder.ApplyConfiguration(new AssetConfig());
        }
    }
}
