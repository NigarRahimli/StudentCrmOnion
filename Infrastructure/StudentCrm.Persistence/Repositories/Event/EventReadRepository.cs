using StudentCrm.Application.Repositories;
using StudentCrm.Domain.Entities;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories
{
    public class EventReadRepository:ReadRepository<StudentCrm.Domain.Entities.Event>, IEventReadRepository
    {
        public EventReadRepository(AppDbContext context):base(context) { 


        }
        
        
    }
}
