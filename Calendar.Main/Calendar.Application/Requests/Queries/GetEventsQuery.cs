using Calendar.Domain.Entities;
using MediatR;

namespace Calendar.Application.Requests.Queries;

public class GetEventsQuery : IRequest<List<EventEntity>>
{
    
}