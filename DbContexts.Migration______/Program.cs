using DbContexts;
using Microsoft.EntityFrameworkCore;

namespace DbContexts.Migration
{
    class Program
    {
        static void Main(string[] args)
        {
            var articleContext = ArticleDbContext.Create();
            if (articleContext.AllMigrationsApplied())
            {
                articleContext.Database.Migrate();
            }
        }
    }
}
