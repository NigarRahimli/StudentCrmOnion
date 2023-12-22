using StudentCrm.Application.Repositories.Role;
using StudentCrm.Application.Repositories.Task;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Task
{
    public class TaskReadRepository : ReadRepository<StudentCrm.Domain.Entities.Task>, ITaskReadRepository
    {

        public TaskReadRepository(AppDbContext context) : base(context)
        {


        }
    
    }
}
