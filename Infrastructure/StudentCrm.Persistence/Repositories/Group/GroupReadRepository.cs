using StudentCrm.Application.Repositories.Group;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Group
{
    public class GroupReadRepository:ReadRepository<StudentCrm.Domain.Entities.Group>,IGroupReadRepository
    {

        public GroupReadRepository(AppDbContext context) : base(context)
        {


        }
    }
}
