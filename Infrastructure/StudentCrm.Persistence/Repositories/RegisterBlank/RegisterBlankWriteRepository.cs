using StudentCrm.Application.Repositories.Message;
using StudentCrm.Application.Repositories.RegisterBlank;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.RegisterBlank
{
    public class RegisterBlankWriteRepository : WriteRepository<StudentCrm.Domain.Entities.RegisterBlank>,IRegisterBlankWriteRepository
    {

        public RegisterBlankWriteRepository(AppDbContext context) : base(context)
        {


        }
    }
}
