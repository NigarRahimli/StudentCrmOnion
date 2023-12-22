using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.EmployeeException
{
    public class EmployeeNotValidatedException : Exception
    {
        public EmployeeNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public EmployeeNotValidatedException(string message):base(message)
        {
            
        }
        public EmployeeNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
