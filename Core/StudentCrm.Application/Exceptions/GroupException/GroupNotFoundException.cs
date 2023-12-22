using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.GroupException
{
    public class GroupNotFoundException:Exception
    {
        public GroupNotFoundException() : base("Group not found")
        {
            
        }
        public GroupNotFoundException(string? message) : base(message)
        {

        }
        public GroupNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
