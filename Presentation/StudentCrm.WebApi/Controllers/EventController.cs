using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCrm.Application.Abstraction;
using StudentCrm.Application.DTOs.EventDTOs;

namespace StudentCrm.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpPost("create")]
        public IActionResult CreateEvent([FromBody] EventCreateDTO eventCreateDTO)
        {
            var res=_eventService.CreateEvent(eventCreateDTO);
            return Ok(res);
        }
        [HttpGet("events")]
        public IActionResult GetAllEvents()
        {
            var res = _eventService.GetEvents();
            return Ok(res);
        }
    }
}
