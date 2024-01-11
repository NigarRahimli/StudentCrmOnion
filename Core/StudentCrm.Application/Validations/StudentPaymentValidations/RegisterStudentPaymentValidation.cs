using FluentValidation;
using StudentCrm.Application.DTOs.StudentPaymentDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Validations.StudentPaymentValidations
{
    public class RegisterStudentPaymentValidation: AbstractValidator<StudentPaymentCreateDTO>
    {
        public RegisterStudentPaymentValidation()
        {
            
        }
    }
}
