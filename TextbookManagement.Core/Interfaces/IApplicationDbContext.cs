using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TextbookManagement.Domain;

namespace TextbookManagement.Core.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Textbook> Textbooks { get; }
        DbSet<Order> Orders { get; }
        
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}