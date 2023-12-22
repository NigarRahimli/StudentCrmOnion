using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Repositories.User
{
    public interface IUserWriteRepository : IWriteRepository<StudentCrm.Domain.Entities.User>
    {
    }
}
