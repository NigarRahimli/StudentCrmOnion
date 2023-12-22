using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.RoleException
{
    public class RoleNotValidatedException : Exception
    {
        public RoleNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public RoleNotValidatedException(string message):base(message)
        {
            
        }
        public RoleNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
