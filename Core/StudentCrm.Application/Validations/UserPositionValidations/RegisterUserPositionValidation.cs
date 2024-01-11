using FluentValidation;
using StudentCrm.Application.DTOs.UserPositionDTOs;
using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.UserPositionValidations
{
    public class RegisterUserPositionValidation: AbstractValidator<UserPositionCreateDTO>
    {
    }
}
