using FluentValidation;
using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.MessageValidations
{
    public class RegisterMessageValidation: AbstractValidator<Message>
    {
        public RegisterMessageValidation()
        {
            
        }
    }
}
