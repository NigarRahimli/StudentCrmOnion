using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.UserAttendanceException
{
    public class UserAttendanceNotValidatedException : Exception
    {
        public UserAttendanceNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public UserAttendanceNotValidatedException(string message):base(message)
        {
            
        }
        public UserAttendanceNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
