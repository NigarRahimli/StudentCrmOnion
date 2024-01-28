using AutoMapper;
using FluentValidation;
using IdentityService.Core.Utilities.Results.Concrete.ErrorResults;
using IdentityService.Core.Utilities.Results.Concrete.SuccessResults;
using Microsoft.Extensions.Logging;
using StudentCrm.Application.Abstraction;
using StudentCrm.Application.Attributes;
using StudentCrm.Application.DTOs.EventDTOs;
using StudentCrm.Application.Exceptions.EventException;
using StudentCrm.Application.Repositories;
using StudentCrm.Application.Repositories.Event;
using StudentCrm.Application.Responses;
using StudentCrm.Application.Responses.Abstract;
using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        [Test("createEvent")]
        public async Task<IResult> CreateEvent(EventCreateDTO eventCreateDTO)
        {
            var validation= _eventValidator.Validate(eventCreateDTO);
            if (!validation.IsValid)
            {
                return new ErrorResult( validation.Errors.Select(x=>x.ErrorMessage).ToList().ToString());
            }
            var newEvent = _mapper.Map<Event>(eventCreateDTO);
            _writeRepository.AddAsync(newEvent);
            //problem
            var res = await _writeRepository.SaveAsync();
            //
            return new SuccessResult("Elave olundu");
            
        }

        public async Task<IResult> DeleteEvent(int id)
        {      
            await _writeRepository.RemoveAsync(id);
            await _writeRepository.SaveAsync();
            return new SuccessResult();
        }

        public IDataResult<EventDTO> GetEventById(int id)
        {
            var findEvent = _readRepository.GetWhere(x=>x.Id==id).FirstOrDefault();
            if (findEvent is null) throw new EventNotFoundException();
            var mapToEventList = _mapper.Map<EventDTO>(findEvent);
            return new SuccessDataResult<EventDTO>(mapToEventList);

        }

        public IDataResult<List<EventDTO>> GetEvents()
        {
            var events = _readRepository.GetAll();
            if (!events.Any()) throw new EventNotFoundException();   
            var mapToEventList = _mapper.Map<List<EventDTO>>(events);   
            return new SuccessDataResult<List<EventDTO>>(mapToEventList);
        }

        public async Task<IResult>UpdateEvent(int id, EventUpdateDTO eventUpdateDTO)
        {
            var findEvent = await _readRepository.GetByIdAsync(id);
            var mapToEvent = _mapper.Map<EventUpdateDTO>(findEvent);
            await _writeRepository.SaveAsync();
            return new SuccessResult();

        }
    }
}
