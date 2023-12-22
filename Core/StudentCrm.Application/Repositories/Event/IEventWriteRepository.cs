using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E = StudentCrm.Domain.Entities;

namespace StudentCrm.Application.Repositories.Event
{
    public interface IEventWriteRepository : IWriteRepository<E.Event>
    {
    }
}
