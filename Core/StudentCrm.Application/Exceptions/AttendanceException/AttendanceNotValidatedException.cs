using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.AttendanceException
{
    public class AttendanceNotValidatedException : Exception
    {
        public AttendanceNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public AttendanceNotValidatedException(string message):base(message)
        {
            
        }
        public AttendanceNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
