using FluentValidation;
using StudentCrm.Application.DTOs.RoleDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.RoleValidations
{
    public class RegisterRoleValidation: AbstractValidator<RoleCreateDTO>
    {
        public RegisterRoleValidation()
        {
            
        }
    }
}
