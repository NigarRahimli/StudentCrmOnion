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
    public class TaskWriteRepository : WriteRepository<StudentCrm.Domain.Entities.Task>, ITaskWriteRepository
    {

        public TaskWriteRepository(AppDbContext context) : base(context)
        {


        }
    
    }
}
