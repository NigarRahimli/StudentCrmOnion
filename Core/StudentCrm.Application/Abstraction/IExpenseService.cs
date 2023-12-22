
using StudentCrm.Application.DTOs.ExpenseDTOs;
using StudentCrm.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Abstraction
{
    public interface IExpenseService
    {
        public Task<Result> CreateAttendance(ExpenseCreateDTO eventCreateDTO);
        List<ExpenseDTO> GetEvents();
    }
}
