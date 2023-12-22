using StudentCrm.Application.Repositories.Message;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.Message
{
    public class MessageWriteRepository : WriteRepository<StudentCrm.Domain.Entities.Message>, IMessageWriteRepository
    {

        public MessageWriteRepository(AppDbContext context) : base(context)
        {


        }
    }
}
