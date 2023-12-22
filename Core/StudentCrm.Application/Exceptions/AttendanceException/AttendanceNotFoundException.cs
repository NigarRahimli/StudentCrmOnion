using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.AttendanceException
{
    public class AttendanceNotFoundException : Exception
    {
        public AttendanceNotFoundException() : base("Attendance not found")
        {
            
        }
        public AttendanceNotFoundException(string? message) : base(message)
        {

        }
        public AttendanceNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
