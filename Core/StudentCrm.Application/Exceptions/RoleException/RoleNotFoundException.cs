using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.RoleException
{
    public class RoleNotFoundException : Exception
    {
        public RoleNotFoundException() : base("Role not found")
        {
            
        }
        public RoleNotFoundException(string? message) : base(message)
        {

        }
        public RoleNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
