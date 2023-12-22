using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.MessageException
{
    public class MessageNotFoundException : Exception
    {
        public MessageNotFoundException() : base("Message not found")
        {
            
        }
        public MessageNotFoundException(string? message) : base(message)
        {

        }
        public MessageNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
