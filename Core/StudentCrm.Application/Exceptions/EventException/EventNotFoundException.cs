using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.EventException
{
    public class EventNotFoundException:Exception
    {
        public EventNotFoundException() : base("Event not found")
        {
            
        }
        public EventNotFoundException(string? message) : base(message)
        {

        }
        public EventNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
