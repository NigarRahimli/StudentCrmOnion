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
    internal class InternshipWriteRepository: WriteRepository<StudentCrm.Domain.Entities.Internship>, IInternshipWriteRepository
    {

        public InternshipWriteRepository(AppDbContext context) : base(context)
        {


        }
    
    }
}
