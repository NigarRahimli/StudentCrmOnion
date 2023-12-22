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
    public class RoleWriteRepository : WriteRepository<StudentCrm.Domain.Entities.Role>,IRoleWriteRepository
    {

        public RoleWriteRepository(AppDbContext context) : base(context)
        {


        }
    }
}
