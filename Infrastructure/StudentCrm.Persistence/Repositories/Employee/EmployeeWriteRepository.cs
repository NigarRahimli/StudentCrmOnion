using StudentCrm.Application.Repositories;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Employee
{
    public class EmployeeWriteRepository:WriteRepository<StudentCrm.Domain.Entities.Employee>,IEmployeeWriteRepository
    {
        public EmployeeWriteRepository(AppDbContext context) : base(context)
        {


        }
    }
}
