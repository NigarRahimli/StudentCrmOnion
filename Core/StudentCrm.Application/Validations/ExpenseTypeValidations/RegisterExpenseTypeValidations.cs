using FluentValidation;
using StudentCrm.Application.DTOs.ExpenseTypeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.ExpenceTypeValidations
{
    public class RegisterExpenseTypeValidations: AbstractValidator<ExpenseTypeCreateDTO>
    {
        public RegisterExpenseTypeValidations()
        {
            RuleFor(x=>x.Title).NotEmpty().MinimumLength(3);
        }
    }
}
