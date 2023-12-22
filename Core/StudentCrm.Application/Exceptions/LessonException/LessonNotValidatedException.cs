using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.EventException
{
    public class LessonNotValidatedException : Exception
    {
        public LessonNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public LessonNotValidatedException(string message):base(message)
        {
            
        }
        public LessonNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
