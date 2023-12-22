using StudentCrm.Application.Repositories;
using StudentCrm.Application.Repositories.Employee;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Employee
{
    public class EmployeeReadRepository : ReadRepository<StudentCrm.Domain.Entities.Employee>, IEmployeeReadRepository
    {
        public EmployeeReadRepository(AppDbContext context) : base(context)
        {


        }


    }
}
