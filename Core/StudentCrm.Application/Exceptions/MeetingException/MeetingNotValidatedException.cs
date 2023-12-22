using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.MeetingException
{
    public class MeetingNotValidatedException : Exception
    {
        public MeetingNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public MeetingNotValidatedException(string message):base(message)
        {
            
        }
        public MeetingNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
