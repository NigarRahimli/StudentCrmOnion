using StudentCrm.Application.Repositories.Message;
using StudentCrm.Application.Repositories.Position;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Position
{
    public class PositionReadRepository : ReadRepository<StudentCrm.Domain.Entities.Position>, IPositionReadRepository
    {

        public PositionReadRepository(AppDbContext context) : base(context)
        {


        }
    }
}
