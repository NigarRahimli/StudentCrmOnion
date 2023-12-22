using FluentValidation;
using StudentCrm.Application.DTOs.EventDTOs;


namespace StudentCrm.Application.Validations.EventValidations
{
    public class RegisterEventValidation:AbstractValidator<EventCreateDTO>
    {
        public RegisterEventValidation()
        {
            RuleFor(x=>x.Title).NotEmpty().MinimumLength(3).MaximumLength(6).WithMessage("3den asagi olmamalidir")/*.Must(x=>x.ToString()=="a")*/;
        }
    }
}
