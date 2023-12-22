using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.StudentException
{
    public class StudentNotValidatedException : Exception
    {
        public StudentNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public StudentNotValidatedException(string message):base(message)
        {
            
        }
        public StudentNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
