using StudentCrm.Application.Repositories.Role;
using StudentCrm.Application.Repositories.User;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.User
{
    public class UserReadRepository : ReadRepository<StudentCrm.Domain.Entities.User>, IUserReadRepository
    {

        public UserReadRepository(AppDbContext context) : base(context)
        {


        }
    
    }
}
