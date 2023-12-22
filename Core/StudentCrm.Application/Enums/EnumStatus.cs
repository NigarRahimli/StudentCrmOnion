using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.Enums
{
    public enum EnumStatus
    {
        InProgress,
        Completed,
        //assigned to a team member but has not started yet
        Assigned,
        //Has not started yet
        ToDo,
        //awaiting for review
        Pending,
        //cannot proceed due to dependency or issue
        Blocked,
        Rejected,
        Late

    }
}
