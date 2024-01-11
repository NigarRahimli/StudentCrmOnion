using FluentValidation;
using StudentCrm.Application.DTOs.SatisfactionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.SatisfactionValidations
{
    public class RegisterSatisfactionValidation: AbstractValidator<SatisfactionCreateDTO>
    {
        public RegisterSatisfactionValidation()
        {
            
        }
    }
}
