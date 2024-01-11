using FluentValidation;
using StudentCrm.Application.DTOs.GroupDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.GroupValidations
{
    public class RegisterGroupValidation: AbstractValidator<GroupCreateDTO>
    {
        public RegisterGroupValidation()
        {
            
        }
    }
}
