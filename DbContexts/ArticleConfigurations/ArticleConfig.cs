using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Article.Entities;

namespace DbContexts.ArticleConfigurations
{
    public class ArticleConfig : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> entity)
        {
            entity.Property(p => p.ArticleId);
            entity.Property(p => p.AttachmentURLsComma);
            entity.Property(x => x.BiodataURL);
            entity.Property(x => x.Commits);
            entity.Property(x => x.Content);

            entity.Property(x => x.CreatedDateTime).HasColumnType("datetime2(7)"); //SqlDbType.DateTime2.ToString()
            entity.Property(x => x.Description);
            entity.Property(x => x.HireMe);
            entity.Property(x => x.License);
            entity.Property(x => x.NatureKeysComma);
            entity.Property(x => x.OpenSourceUrls);
            entity.Property(x => x.RelatedTo1);
            entity.Property(x => x.RelatedTo12);
            entity.Property(x => x.RelatedTo123);
            entity.Property(x => x.RelatedTo1234);
            entity.Property(x => x.RelatedTo12345);
            entity.Property(x => x.SocialURLsWithComma);

            entity.Property(x => x.Tag1);
            entity.Property(x => x.Tag2);
            entity.Property(x => x.Tag3);
            entity.Property(x => x.Tag4);
            entity.Property(x => x.Tag5);
            entity.Property(x => x.Tag6);
            entity.Property(x => x.Tag7);
            entity.Property(x => x.Tag8);
            entity.Property(x => x.Tag9);
            entity.Property(x => x.Tag10);
            entity.Property(x => x.Tag11);
            entity.Property(x => x.Tag12);
            entity.Property(x => x.TechVersionsComma);
            entity.Property(x => x.Title);
            entity.Property(x => x.UpdatedDateTime).HasColumnType("datetime2(7)");
            entity.Property(x => x.UserAvatar);
            entity.Property(x => x.UserEmail);
            entity.Property(x => x.UserId);
            entity.Property(x => x.UserName);
            entity.Property(x => x.UserPhoneNumber);
            entity.Property(x => x.Votes);
            //relationships
        }
    }
}