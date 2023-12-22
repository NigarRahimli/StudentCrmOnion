using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.RoleException
{
    public class SatisfactionNotValidatedException : Exception
    {
        public SatisfactionNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public SatisfactionNotValidatedException(string message):base(message)
        {
            
        }
        public SatisfactionNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
