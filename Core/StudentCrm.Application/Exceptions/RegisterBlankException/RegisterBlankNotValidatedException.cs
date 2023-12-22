using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.RegisterBlankException
{
    public class RegisterBlankNotValidatedException : Exception
    {
        public RegisterBlankNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public RegisterBlankNotValidatedException(string message):base(message)
        {
            
        }
        public RegisterBlankNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
