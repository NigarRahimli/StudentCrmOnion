using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.DTOs.UserDTOs
{
    public class UserCreateDTO
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Password { get; set; }
        public bool PasswordRepeat { get; set; }
    }
}
