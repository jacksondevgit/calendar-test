using Calendar.Application.Requests.Commands;
using MediatR;

namespace Calendar.Application.Requests.Handlers;

public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand>
{
    public Task Handle(CreateEventCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}