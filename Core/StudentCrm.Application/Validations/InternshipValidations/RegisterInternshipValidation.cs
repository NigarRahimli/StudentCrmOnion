using FluentValidation;
using StudentCrm.Application.DTOs.InternshipDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.InternshipValidations
{
    public class RegisterInternshipValidation: AbstractValidator<InternshipCreateDTO>
    {
        public RegisterInternshipValidation()
        {
            
        }
    }
}
