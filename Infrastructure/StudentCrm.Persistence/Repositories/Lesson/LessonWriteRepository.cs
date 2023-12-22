using StudentCrm.Application.Repositories.Lesson;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Lesson
{
    public class LessonWriteRepository : WriteRepository<StudentCrm.Domain.Entities.Lesson>, ILessonWriteRepository
    {

        public LessonWriteRepository(AppDbContext context) : base(context)
        {


        }
    }
}
