using MediatR;

namespace Calendar.Application.Requests.Commands;

public class CreateEventCommand : IRequest
{
    public DateTime Schedule { get; set; }
}