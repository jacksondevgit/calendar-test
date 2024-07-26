using Calendar.Application.Requests.Commands;
using Calendar.Application.Requests.Queries;
using Calendar.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Calendar.Main.Controllers.Api;

public class CalendarController : ApiControllerBase
{
    [HttpPost("CreateEvent")]
    public async Task CreateEventAsync([FromBody] CreateEventCommand request) =>
        await Mediator.Send(request);
    
    [HttpPost("UpdateEvent")]
    public async Task CreateEventAsync([FromBody] UpdateEventCommand request) =>
        await Mediator.Send(request);
    
    [HttpGet("GetEvents")]
    public async Task<List<EventEntity>> GetEventsAsync() =>
        await Mediator.Send(new GetEventsQuery());
}