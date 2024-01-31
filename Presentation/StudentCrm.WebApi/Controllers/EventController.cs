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
        public async Task<IActionResult> CreateEvent([FromBody] EventCreateDTO eventCreateDTO)
        {
            var res = await _eventService.CreateEvent(eventCreateDTO);
            return Ok(res);
        }
        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] EventUpdateDTO eventUpdate)
        {
            var res =await  _eventService.UpdateEvent(id, eventUpdate);
            return Ok(res);
        }
        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _eventService.DeleteEvent(id);
            return Ok(result);
        }

        [HttpGet("getallevents")]
        public IActionResult GetAllEvents()
        {
            var res = _eventService.GetEvents();
            return Ok(res);
        }
        [HttpGet("geteventbyid/{id}")]
        public IActionResult GetEventById(int id)
        {
            var res = _eventService.GetEventById(id);
            return Ok(res);
        }
    }
}
