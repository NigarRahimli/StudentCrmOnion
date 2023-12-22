using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.ExpenseTypeException
{
    public class ExpenseTypeNotValidatedException : Exception
    {
        public ExpenseTypeNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public ExpenseTypeNotValidatedException(string message):base(message)
        {
            
        }
        public ExpenseTypeNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
