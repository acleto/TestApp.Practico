using Microsoft.EntityFrameworkCore;
using TestApp.Practico.Domain;

namespace TestApp.Practico.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<ArticleRecord> ArticleRecord { get; set; }

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

    }
}
