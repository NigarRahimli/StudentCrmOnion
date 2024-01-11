using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.TaskValidations
{
    public class RegisterTaskValidation: AbstractValidator<Task>
    {
        public RegisterTaskValidation()
        {
            
        }
    }
}
