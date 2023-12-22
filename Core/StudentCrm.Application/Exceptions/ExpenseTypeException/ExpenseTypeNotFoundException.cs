using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.ExpenseTypeException
{
    public class EmployeeNotFoundException:Exception
    {
        public EmployeeNotFoundException() : base("ExpenseType not found")
        {
            
        }
        public EmployeeNotFoundException(string? message) : base(message)
        {

        }
        public EmployeeNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
