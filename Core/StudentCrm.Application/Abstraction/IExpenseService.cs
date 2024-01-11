
using StudentCrm.Application.DTOs.ExpenseDTOs;
using StudentCrm.Application.Responses;
using StudentCrm.Application.Responses.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Abstraction
{
    public interface IExpenseService
    {
        Task <IResult> CreateAttendance(ExpenseCreateDTO eventCreateDTO);
        List<ExpenseDTO> GetEvents();
    }
}
