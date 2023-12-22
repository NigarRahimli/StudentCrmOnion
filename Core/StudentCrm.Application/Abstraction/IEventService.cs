using StudentCrm.Application.DTOs.EventDTOs;
using StudentCrm.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Abstraction
{
    public interface IEventService
    {
        public Task<Result> CreateEvent(EventCreateDTO eventCreateDTO); 
        List<EventDTO> GetEvents();
    }
}
