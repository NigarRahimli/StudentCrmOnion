using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.StudentPaymentException
{
    public class StudentPaymentNotFoundException : Exception
    {
        public StudentPaymentNotFoundException() : base("StudentPayment not found")
        {
            
        }
        public StudentPaymentNotFoundException(string? message) : base(message)
        {

        }
        public StudentPaymentNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
