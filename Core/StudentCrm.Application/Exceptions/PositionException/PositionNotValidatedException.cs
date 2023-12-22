using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.PositionException
{
    public class PositionNotValidatedException : Exception
    {
        public PositionNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public PositionNotValidatedException(string message):base(message)
        {
            
        }
        public PositionNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
