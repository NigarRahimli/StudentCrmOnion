using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Repositories.Message
{
    public interface IMessageWriteRepository : IWriteRepository<StudentCrm.Domain.Entities.Message>
    {
    }
}
