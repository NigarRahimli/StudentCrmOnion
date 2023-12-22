using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.ExpenseException
{
    public class ExpenseNotValidatedException:Exception
    {
        public ExpenseNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public ExpenseNotValidatedException(string message):base(message)
        {
            
        }
        public ExpenseNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
