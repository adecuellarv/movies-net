using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Entities;


namespace WebApplication1.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Actors> Actors { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Movies> Movies { get; set; }
    }
}
