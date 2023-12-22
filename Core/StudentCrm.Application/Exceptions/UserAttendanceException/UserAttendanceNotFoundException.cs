using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.UserAttendanceException
{
    public class UserAttendanceNotFoundException : Exception
    {
        public UserAttendanceNotFoundException() : base("User not found")
        {
            
        }
        public UserAttendanceNotFoundException(string? message) : base(message)
        {

        }
        public UserAttendanceNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
