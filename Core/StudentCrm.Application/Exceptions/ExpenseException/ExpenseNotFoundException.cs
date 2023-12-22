using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.ExpenseException
{
    public class ExpenseNotFoundException : Exception
    {
        public ExpenseNotFoundException() : base("Expense not found")
        {
            
        }
        public ExpenseNotFoundException(string? message) : base(message)
        {

        }
        public ExpenseNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
