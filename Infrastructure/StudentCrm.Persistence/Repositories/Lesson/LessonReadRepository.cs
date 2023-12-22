using StudentCrm.Application.Repositories.InformationList;
using StudentCrm.Application.Repositories.Lesson;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Lesson
{
    public class LessonReadRepository: ReadRepository<StudentCrm.Domain.Entities.Lesson>, ILessonReadRepository
    {

        public LessonReadRepository(AppDbContext context) : base(context)
        {


        }
    
    }
}
