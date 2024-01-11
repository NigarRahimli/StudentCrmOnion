using StudentCrm.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Domain.Entities
{
    public class UserAttendance : BaseEntity
    {
        public int UserID { get; set; }
        public DateTime LessonDate { get; set; }
        public bool IsPresent { get; set; }
    }
}

