using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.MeetingException
{
    public class MeetingNotFoundException : Exception
    {
        public MeetingNotFoundException() : base("Meeting not found")
        {
            
        }
        public MeetingNotFoundException(string? message) : base(message)
        {

        }
        public MeetingNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
