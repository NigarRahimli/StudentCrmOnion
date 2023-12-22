using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.TaskException
{
    public class TaskNotFoundException : Exception
    {
        public TaskNotFoundException() : base("Task not found")
        {
            
        }
        public TaskNotFoundException(string? message) : base(message)
        {

        }
        public TaskNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
