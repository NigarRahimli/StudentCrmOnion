using FluentValidation;
using StudentCrm.Application.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.UserValidations
{
    public class RegisterUserValidation: AbstractValidator<UserCreateDTO>
    {
        public RegisterUserValidation()
        {
            
        }
    }

}
