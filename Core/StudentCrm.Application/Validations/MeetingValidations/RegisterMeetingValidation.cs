using FluentValidation;
using StudentCrm.Application.DTOs.MeetingDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.MeetingValidations
{
    public class RegisterMeetingValidation: AbstractValidator<MeetingCreateDTO>
    {
        public RegisterMeetingValidation()
        {
            
        }
    }
}
