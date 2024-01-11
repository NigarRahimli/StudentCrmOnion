using FluentValidation;
using StudentCrm.Application.DTOs.ExpenseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.ExpenceValidations
{
    public class RegisterExpenseValidation: AbstractValidator<ExpenseCreateDTO>
    {
        public RegisterExpenseValidation()
        {
            RuleFor(x=>x.Note).NotEmpty().MinimumLength(3).MaximumLength(6).WithMessage("3den asagi olmamalidir")/*.Must(x=>x.ToString()=="a")*/;

        }
    }
}
