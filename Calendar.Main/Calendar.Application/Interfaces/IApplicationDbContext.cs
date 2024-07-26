using Calendar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<EventEntity> Events { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new());
}