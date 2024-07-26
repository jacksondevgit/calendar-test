using Calendar.Application.Requests.Queries;
using MediatR;

namespace Calendar.Application.Requests.Handlers;

public class GetEventsQueryHandler : IRequestHandler<GetEventsQuery>
{
    public Task Handle(GetEventsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}