using StudentCrm.Application.Repositories.InformtionList;
using StudentCrm.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Persistence.Repositories.InformationList
{
    public class InformationListWriteRepository:WriteRepository<StudentCrm.Domain.Entities.InformationList>,IInformationListWriteRepository
    {

        public InformationListWriteRepository(AppDbContext context) : base(context)
    {


    }
    
    }
}
