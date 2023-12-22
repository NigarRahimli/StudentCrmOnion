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
    public class SatisfactionWriteRepository : WriteRepository<StudentCrm.Domain.Entities.Satisfaction>, ISatisfactionWriteRepository
    {

        public SatisfactionWriteRepository(AppDbContext context) : base(context)
        {


        }
    }
}
