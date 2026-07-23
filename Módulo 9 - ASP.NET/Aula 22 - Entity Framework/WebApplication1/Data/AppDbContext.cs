using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options){}
        public DbSet<WebApplication1.Models.Produto> Produto {get; set;}
        public DbSet<WebApplication1.Models.Aluno> Aluno { get; set; }
    }
}
