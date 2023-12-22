using StudentCrm.Application.Repositories.ExpenseType;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.ExpenseType
{
    public class ExpenseTypeReadRepository:ReadRepository<StudentCrm.Domain.Entities.ExpenseType>,IExpenseTypeReadRepository
    {
        public ExpenseTypeReadRepository(AppDbContext context) : base(context)
        {


        }
    }
}
