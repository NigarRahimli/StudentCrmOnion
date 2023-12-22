using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.TaskException
{
    public class TaskNotValidatedException : Exception
    {
        public TaskNotValidatedException():base("Butun xanalari doldurun")
        {
            
        }
        public TaskNotValidatedException(string message):base(message)
        {
            
        }
        public TaskNotValidatedException(string message, Exception e):base(message, e)
        {

        } 
    }

}
