using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.UserPositionException
{
    public class UserPositionNotValidatedException : Exception
    {
        public UserPositionNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public UserPositionNotValidatedException(string message):base(message)
        {
            
        }
        public UserPositionNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
