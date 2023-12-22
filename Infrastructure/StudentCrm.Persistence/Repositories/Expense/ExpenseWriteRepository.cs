using StudentCrm.Application.Repositories.Expense;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Expense
{
    public class ExpenseWriteRepository:WriteRepository<StudentCrm.Domain.Entities.Expense>,IExpenseWriteRepository
    {
        public ExpenseWriteRepository(AppDbContext context) : base(context)
        {


        }

    }
}
