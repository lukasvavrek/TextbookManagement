using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TextbookManagement.Core.Interfaces;
using TextbookManagement.Domain;

namespace TextbookManagement.Persistence
{
    public class TextbookManagementDbContext : DbContext, IApplicationDbContext
    {
        public TextbookManagementDbContext(DbContextOptions<TextbookManagementDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Textbook> Textbooks { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}