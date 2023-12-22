using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.EventException
{
    public class EventNotValidatedException : Exception
    {
        public EventNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public EventNotValidatedException(string message):base(message)
        {
            
        }
        public EventNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
