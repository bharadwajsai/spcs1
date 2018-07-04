﻿using Microsoft.EntityFrameworkCore;
using Models.Article.Entities;

namespace DbContexts
{
    //https://github.com/damienbod/AspNetCoreMultipleProject/blob/master/src/DataAccessMsSqlServerProvider/DomainModelMsSqlServerContext.cs
    public class ArticleDbContext : DbContext
    {
        public ArticleDbContext(DbContextOptions<ArticleDbContext> options) : base(options)
        {
        }

        public static ArticleDbContext Create(string connection = "Server=localhost;Database=identity;Trusted_Connection=True;")
        {
            return new ArticleDbContext(new DbContextOptionsBuilder<ArticleDbContext>().UseSqlServer(connection).Options);
        }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //public DbSet<DataEventRecord> DataEventRecords { get; set; }
        //public DbSet<SourceInfo> SourceInfos { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<DataEventRecord>().HasKey(m => m.DataEventRecordId);
        //    builder.Entity<SourceInfo>().HasKey(m => m.SourceInfoId);
        //    // shadow properties
        //    builder.Entity<DataEventRecord>().Property<DateTime>("UpdatedTimestamp");
        //    builder.Entity<SourceInfo>().Property<DateTime>("UpdatedTimestamp");
        //    base.OnModelCreating(builder);
        //}
    }
}
