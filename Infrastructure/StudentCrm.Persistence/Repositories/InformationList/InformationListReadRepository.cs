using StudentCrm.Application.Repositories.InformationList;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.InformationList
{
    public class InformationListReadRepository:ReadRepository<StudentCrm.Domain.Entities.InformationList>,IInformationListReadRepository
    {

        public InformationListReadRepository(AppDbContext context) : base(context)
        {


        }
    }
}
