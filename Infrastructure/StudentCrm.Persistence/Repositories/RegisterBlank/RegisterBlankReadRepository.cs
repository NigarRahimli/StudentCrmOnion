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
    public class RegisterBlankReadRepository : ReadRepository<StudentCrm.Domain.Entities.RegisterBlank>, IRegisterBlankReadRepository
    {

        public RegisterBlankReadRepository(AppDbContext context) : base(context)
        {


        }
    }
}
