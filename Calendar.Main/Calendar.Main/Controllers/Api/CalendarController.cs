using Calendar.Application.Requests.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Calendar.Main.Controllers.Api;

public class CalendarController : ApiControllerBase
{
    [HttpPost("CreateEvent")]
    public async Task CreateEventAsync(CreateEventCommand request) =>
        await Mediator.Send(request);
    
    [HttpPost("UpdateEvent")]
    public async Task CreateEventAsync(UpdateEventCommand request) =>
        await Mediator.Send(request);
}