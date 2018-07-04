using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Ad.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbContexts.AdConfigurations
{
    public class AssetConfig : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> entity)
        {
            entity.ToTable("Asset");
            
            //entity.HasKey(a => a.AssetId);  //by default will take <typename>Id format, this is like that.

            entity.Property(p => p.AssetId);
            entity.Property(p => p.Json);
        }
    }
}
