using Calendar.Application.Interfaces;
using Calendar.Application.Requests.Commands;
using Calendar.Domain.Entities;
using MediatR;

namespace Calendar.Application.Requests.Handlers;

public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateEventCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task Handle(CreateEventCommand request, CancellationToken cancellationToken)
    {
        var schedule = new EventEntity
        {
            Schedule = request.Schedule
        };

        _context.Events.Add(schedule);
        await _context.SaveChangesAsync(cancellationToken);
    }
}