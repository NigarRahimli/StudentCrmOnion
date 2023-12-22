using StudentCrm.Application.Repositories;
using StudentCrm.Application.Repositories.Event;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Event
{

    public class EventWriteRepository : WriteRepository<StudentCrm.Domain.Entities.Event>, IEventWriteRepository
    {
        public EventWriteRepository(AppDbContext context) : base(context)
        {


        }


    }
}
