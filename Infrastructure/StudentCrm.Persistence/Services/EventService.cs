using AutoMapper;
using FluentValidation;
using StudentCrm.Application.Abstraction;
using StudentCrm.Application.Attributes;
using StudentCrm.Application.DTOs.EventDTOs;
using StudentCrm.Application.Exceptions.EventException;
using StudentCrm.Application.Repositories;
using StudentCrm.Application.Repositories.Event;
using StudentCrm.Application.Responses;
using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Services
{
    public class EventService : IEventService
    {
        private readonly IEventReadRepository _readRepository;
        private readonly IEventWriteRepository _writeRepository;
        private readonly IMapper _mapper;
        private readonly  IValidator<EventCreateDTO> _eventValidator;
        public EventService(IEventReadRepository readRepository, IEventWriteRepository writeRepository, IMapper mapper, IValidator<EventCreateDTO> eventValidator)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
            _eventValidator = eventValidator;
        }

        [Test("nese")]
        public async Task<Result> CreateEvent(EventCreateDTO eventCreateDTO)
        {
            var validation= _eventValidator.Validate(eventCreateDTO);
            if (!validation.IsValid)
            {
                return new Result(false, validation.Errors.Select(x=>x.ErrorMessage).ToList());
            }
            var newEvent = _mapper.Map<Event>(eventCreateDTO);
            _writeRepository.AddAsync(newEvent);
            var res = await _writeRepository.SaveAsync();
            return new Result(true,"Elave olundu");
            
        }

        public List<EventDTO> GetEvents()
        {
            var events = _readRepository.GetAll();
            if (!events.Any()) throw new EventNotFoundException();
            var map = _mapper.Map <List<EventDTO>>(events);
            return map;
            
        }
    }
}
