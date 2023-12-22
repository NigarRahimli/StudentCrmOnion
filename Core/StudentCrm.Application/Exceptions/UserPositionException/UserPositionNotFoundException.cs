using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Exceptions.UserException
{
    public class UserPositionNotFoundException: Exception
    {
        public UserPositionNotFoundException() : base("UserPostion not found")
        {
            
        }
        public UserPositionNotFoundException(string? message) : base(message)
        {

        }
        public UserPositionNotFoundException(string? message,Exception? innerException) : base(message,innerException)
        {

        }
    }
}
