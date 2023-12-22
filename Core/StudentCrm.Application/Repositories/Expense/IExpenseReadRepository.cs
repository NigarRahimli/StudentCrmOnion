using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Repositories.Expenses
{
    public interface IExpenseReadRepository : IReadRepository<StudentCrm.Domain.Entities.Expense>
    {
    }
}
