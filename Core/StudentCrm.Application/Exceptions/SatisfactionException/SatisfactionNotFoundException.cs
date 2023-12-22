using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.RoleException
{
    public class SatisfactionNotFoundException : Exception
    {
        public SatisfactionNotFoundException() : base("Satisfaction not found")
        {
            
        }
        public SatisfactionNotFoundException(string? message) : base(message)
        {

        }
        public SatisfactionNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
