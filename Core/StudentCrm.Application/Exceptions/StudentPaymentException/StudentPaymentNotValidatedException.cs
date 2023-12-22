using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.StudentPaymentException
{
    public class StudentPaymentNotValidatedException : Exception
    {
        public StudentPaymentNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public StudentPaymentNotValidatedException(string message):base(message)
        {
            
        }
        public StudentPaymentNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
