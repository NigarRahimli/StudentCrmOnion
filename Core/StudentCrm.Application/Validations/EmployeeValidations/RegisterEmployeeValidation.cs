using FluentValidation;
using StudentCrm.Application.DTOs.EmployeeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.EmployeeValidations
{
    public class RegisterEmployeeValidation: AbstractValidator<EmployeeCreateDTO>
    {
        public RegisterEmployeeValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(3).MaximumLength(6).WithMessage("3den asagi olmamalidir")/*.Must(x=>x.ToString()=="a")*/;

        }
    }
}
