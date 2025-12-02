using Microsoft.EntityFrameworkCore;
using tp3.Models;

namespace tp3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employe> Employes { get; set; }
    }
}
