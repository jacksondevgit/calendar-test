using Calendar.Application.Interfaces;
using Calendar.Application.Requests.Queries;
using Calendar.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Application.Requests.Handlers;

public class GetEventsQueryHandler : IRequestHandler<GetEventsQuery, List<EventEntity>>
{
    private readonly IApplicationDbContext _context;

    public GetEventsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<EventEntity>> Handle(GetEventsQuery request, CancellationToken cancellationToken)
    {
        var result = await _context.Events.AsNoTracking()
            .ToListAsync(cancellationToken);
        return result;
    }
}