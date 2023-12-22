using StudentCrm.Application.Repositories;
using StudentCrm.Application.Repositories.Attendance;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Attendance
{
    public class AttendanceReadRepository :ReadRepository<StudentCrm.Domain.Entities.Attendance>, IAttendanceReadRepository
    {
        public AttendanceReadRepository(AppDbContext context) : base(context)
        {


        }
    }
}
