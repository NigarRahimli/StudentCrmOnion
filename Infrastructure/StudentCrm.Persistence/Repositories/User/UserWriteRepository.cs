using StudentCrm.Application.Repositories.Role;
using StudentCrm.Application.Repositories.User;
using StudentCrm.Persistence.Contexts;

namespace StudentCrm.Persistence.Repositories.User
{
    public class UserWriteRepository : WriteRepository<StudentCrm.Domain.Entities.User>,IUserWriteRepository
    {

        public UserWriteRepository(AppDbContext context) : base(context)
        {


        }
    }
}
