using StudentCrm.Application.Repositories.Lesson;
using StudentCrm.Application.Repositories.Meeting;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Meeting
{
    public class MeetingReadRepository : ReadRepository<StudentCrm.Domain.Entities.Meeting>, IMeetingReadRepository
    {

        public MeetingReadRepository(AppDbContext context) : base(context)
        {


        }
    
    }
}
