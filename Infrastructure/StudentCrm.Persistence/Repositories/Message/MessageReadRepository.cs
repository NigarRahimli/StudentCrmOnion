using StudentCrm.Application.Repositories.Lesson;
using StudentCrm.Application.Repositories.Message;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Message
{
    public class MessageReadRepository : ReadRepository<StudentCrm.Domain.Entities.Message>, IMessageReadRepository
    {

        public MessageReadRepository(AppDbContext context) : base(context)
        {


        }
    }
}
