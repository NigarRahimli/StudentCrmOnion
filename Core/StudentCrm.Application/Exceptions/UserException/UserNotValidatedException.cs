using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.UserException
{
    public class UserNotValidatedException : Exception
    {
        public UserNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public UserNotValidatedException(string message):base(message)
        {
            
        }
        public UserNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
