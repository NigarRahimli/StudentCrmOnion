using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.InternshipException
{
    public class InternshipNotValidatedException : Exception
    {
        public InternshipNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public InternshipNotValidatedException(string message):base(message)
        {
            
        }
        public InternshipNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
