using StudentCrm.Application.Repositories.InformationList;
using StudentCrm.Application.Repositories.Internship;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Internship
{
    public class InternshipReadRepository: ReadRepository<StudentCrm.Domain.Entities.Internship>, IInternshipReadRepository
    {

        public InternshipReadRepository(AppDbContext context) : base(context)
        {


        }
    
    }
}
