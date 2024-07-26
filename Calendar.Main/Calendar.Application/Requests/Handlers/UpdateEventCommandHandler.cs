using Calendar.Application.Requests.Commands;
using MediatR;

namespace Calendar.Application.Requests.Handlers;

public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand>
{
    public Task Handle(UpdateEventCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}