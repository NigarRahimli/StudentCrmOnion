using StudentCrm.Application.Repositories.Group;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Group
{
    public class GroupWriteRepository:WriteRepository<StudentCrm.Domain.Entities.Group>,IGroupWriteRepository
    {

        public GroupWriteRepository(AppDbContext context) : base(context)
        {


        }
    }
}
