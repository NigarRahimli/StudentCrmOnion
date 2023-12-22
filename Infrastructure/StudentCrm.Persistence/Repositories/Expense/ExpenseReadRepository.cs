using StudentCrm.Application.Repositories.Expenses;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Expense
{
    public class ExpenseReadRepository: ReadRepository<StudentCrm.Domain.Entities.Expense>, IExpenseReadRepository
    {
        public ExpenseReadRepository(AppDbContext context) : base(context)
        {


        }
    }
}
