using StudentCrm.Application.DTOs.EventDTOs;
using StudentCrm.Application.Responses;
using StudentCrm.Application.Responses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Abstraction
{
    public interface IEventService
    {
        Task<IResult> CreateEvent(EventCreateDTO eventCreateDTO); 
        public List<EventDTO> GetEvents();
        //public List<EventDTO> GetEventsByCondition();
        //List<EventDTO> GetEventsBySingle();

    }
}
