using StudentCrm.Application.Repositories.Role;
using StudentCrm.Application.Repositories.Satisfaction;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Satisfaction
{
    public class SatisfactionReadRepository : ReadRepository<StudentCrm.Domain.Entities.Satisfaction>, ISatisfactionReadRepository
    {

        public SatisfactionReadRepository(AppDbContext context) : base(context)
        {


        }
    }
}
