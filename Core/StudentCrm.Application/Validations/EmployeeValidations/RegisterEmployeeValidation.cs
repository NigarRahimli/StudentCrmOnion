using FluentValidation;
using StudentCrm.Application.DTOs.EmployeeDTOs;


namespace StudentCrm.Application.Validations.EmployeeValidations
{
    public class RegisterEmployeeValidation: AbstractValidator<EmployeeCreateDTO>
    {
        public RegisterEmployeeValidation()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(3).WithMessage("3den asagi olmamalidir");

        }
    }
}
