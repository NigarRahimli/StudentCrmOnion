using StudentCrm.Application.Repositories.Message;
using StudentCrm.Application.Repositories.Role;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Role
{
    public class RoleReadRepository : ReadRepository<StudentCrm.Domain.Entities.Role>, IRoleReadRepository
    {

        public RoleReadRepository(AppDbContext context) : base(context)
        {


        }
    }
}
