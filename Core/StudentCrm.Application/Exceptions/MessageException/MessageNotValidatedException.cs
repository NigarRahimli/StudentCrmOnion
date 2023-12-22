using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.MessageException
{
    public class MessageNotValidatedException : Exception
    {
        public MessageNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public MessageNotValidatedException(string message):base(message)
        {
            
        }
        public MessageNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
