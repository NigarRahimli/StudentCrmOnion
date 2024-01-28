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
        public IDataResult<List<EventDTO>> GetEvents();
        public IDataResult<EventDTO> GetEventById(int id);
        Task<IResult> UpdateEvent(int id, EventUpdateDTO eventUpdateDTO);
        Task<IResult> DeleteEvent(int id);
        //public List<EventDTO> GetEventsByCondition();
        //List<EventDTO> GetEventsBySingle();

    }
}
